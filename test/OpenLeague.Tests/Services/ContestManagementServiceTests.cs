namespace OpenLeague.Tests.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FluentAssertions;

    using Moq;

    using NUnit.Framework;

    using OpenLeague.Infrastructure.Commands;
    using OpenLeague.Model.Entities;
    using OpenLeague.Model.Repositories;
    using OpenLeague.Model.Services;

    [TestFixture]
    public class ContestManagementServiceTests
    {
        [Test]
        public void GivenAContestManagementServiceWhenGetAllContestsThenReturnsContestsAsViewModels()
        {
            var mockContestRepository = new Mock<IContestRepository>();
            var contestManagementService = GivenAContestManagementService(mockContestRepository.Object, null);
            mockContestRepository.Setup(mcr => mcr.GetAll()).Returns(
                new List<Contest> { new Contest { Id = Guid.NewGuid(), Name = "Contest1" } }.AsQueryable());
            var contestViewModels = contestManagementService.GetAllContests();
            contestViewModels.Should().HaveCount(1);
        }

        [Test]
        public void GivenAContestMnagementServiceWhenContestDeletedWithIdThenCreatesCommandAndDispatches()
        {
            var commandDispatcher = new Mock<ICommandDispatcher>();
            var contestMmanagementService = GivenAContestManagementService(null, commandDispatcher.Object);
            var contestId = Guid.NewGuid();
            contestMmanagementService.DeleteById(contestId);
            commandDispatcher.Verify(cd => cd.Dispatch(It.IsAny<ICommand>()));
        }

        private static ContestManagementService GivenAContestManagementService(IContestRepository contestRepository, ICommandDispatcher commandDispatcher)
        {
            var contestManagementService = new ContestManagementService(contestRepository, commandDispatcher);
            return contestManagementService;
        }
    }
}
