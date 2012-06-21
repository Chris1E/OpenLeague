
namespace OpenLeague.Tests.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using FluentAssertions;

    using Moq;

    using NUnit.Framework;

    using OpenLeague.Model.Services;
    using OpenLeague.Web.Controllers;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ContestListControllerTests
    {
        [Test]
        public void GivenAContestListController_WhenIndexActionCalled_ThenCreatesAViewWithContests()
        {
            var mockContestManagementService = new Mock<IContestManagementService>();
            var contestListController = new ContestListController(mockContestManagementService.Object);

            mockContestManagementService.Setup(cms => cms.GetAllContests()).Returns(
                new List<ContestViewModel> { new ContestViewModel() });

            var viewModels = contestListController.Index();
            var viewResult = viewModels as ViewResult;

            var contestViewModels = viewResult.Model as IEnumerable<ContestViewModel>;
            contestViewModels.Should().HaveCount(1);
        }
    }
}
