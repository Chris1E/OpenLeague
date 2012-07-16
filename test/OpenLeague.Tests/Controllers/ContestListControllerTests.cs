
namespace OpenLeague.Tests.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    using FluentAssertions;

    using Moq;

    using NUnit.Framework;

    using OpenLeague.Model.Services;
    using OpenLeague.Model.ViewModels;
    using OpenLeague.Web.Controllers;

    public class ContestListControllerTests
    {
        [Test]
        public void GivenAContestListControllerWhenIndexActionCalledThenCreatesAViewWithContests()
        {
            var mockContestManagementService = new Mock<IContestManagementService>();
            var contestListController = GivenAContestListController(mockContestManagementService.Object);

            mockContestManagementService.Setup(cms => cms.GetAllContests()).Returns(
                new List<ContestViewModel> { new ContestViewModel() });

            var viewModels = contestListController.Index();
            var viewResult = viewModels as ViewResult;

            var contestViewModels = viewResult.Model as IEnumerable<ContestViewModel>;
            contestViewModels.Should().HaveCount(1);
        }

        [Test]
        public void GivenAContestListControllerWhenContestDeltedThenDeletesAndRedirectsToIndex()
        {
            var mockContestManagementService = new Mock<IContestManagementService>();
            var contestListController = GivenAContestListController(mockContestManagementService.Object);
            var contestId = Guid.NewGuid();

            var actionResult = contestListController.Delete(contestId);
            mockContestManagementService.Verify(cms => cms.DeleteById(contestId));
            var redirectToActionResult = actionResult as RedirectToRouteResult;
            redirectToActionResult.RouteName.Should().Be("Index");
        }

        private static ContestListController GivenAContestListController(IContestManagementService mockContestManagementService)
        {
            var contestListController = new ContestListController(mockContestManagementService);
            return contestListController;
        }
    }
}
