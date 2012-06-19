namespace OpenLeague.Tests.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FluentAssertions;

    using Moq;

    using NUnit.Framework;

    using OpenLeague.Model.Entities;
    using OpenLeague.Model.Repositories;
    using OpenLeague.Model.Services;

    [TestFixture]
    public class ContestManagementServiceTests
    {
        [Test]
        public void GivenContestManagementService_WhenGetAllContests_ThenReturnsContestsAsViewModels()
    {
        var mockContestRepository = new Mock<IContestRepository>();
        var contestManagementService = new ContestManagementService(mockContestRepository.Object);
        mockContestRepository.Setup(mcr => mcr.GetAll()).Returns(
            new List<Contest> { new Contest { Id = Guid.NewGuid(), Name = "Contest1" } }.AsQueryable());
        var contestViewModels = contestManagementService.GetAllContests();
        contestViewModels.Should().HaveCount(1);
    }
    }
}
