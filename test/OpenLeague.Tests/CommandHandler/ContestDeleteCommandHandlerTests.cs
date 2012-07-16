namespace OpenLeague.Tests.CommandHandler
{
    using System;

    using FluentAssertions;

    using Moq;

    using NUnit.Framework;

    using OpenLeague.Infrastructure.Persistence;
    using OpenLeague.Model.Command;
    using OpenLeague.Model.CommandHandlers;
    using OpenLeague.Model.Entities;
    using OpenLeague.Model.Repositories;

    [TestFixture]
    public class ContestDeleteCommandHandlerTests
    {
        [Test]
        public void GivenAContestDeleteCommandHandlerWhenIDeleteAContestThenTheContestIsMArkedAsDeleted()
        {
            var contestId = Guid.NewGuid();
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            var contest = new Contest { Id = contestId, Deleted = false };
            var mockContestRepository = new Mock<IContestRepository>();
            mockContestRepository.Setup(cr => cr.GetSingle(contestId)).Returns(contest);
            var contestDeleteCommandHandler = new ContestDeleteCommandHandler(mockContestRepository.Object, mockUnitOfWork.Object);
            var contestDeleteCommand = new ContestDeleteCommand(contestId);
            contestDeleteCommandHandler.Execute(contestDeleteCommand);

            mockContestRepository.Verify(cr => cr.Update(contest));
            mockUnitOfWork.Verify(uow => uow.Commit());
            contest.Deleted.Should().BeTrue("Unexpected Delete value");
        }
    }
}
