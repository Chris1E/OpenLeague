namespace OpenLeague.Web.Controllers
{
    using System.Web.Mvc;

    using OpenLeague.Model.Services;

    public class ContestListController : Controller
    {
        private readonly IContestManagementService contestManagementService;

        public ContestListController(IContestManagementService contestManagementService)
        {
            this.contestManagementService = contestManagementService;
        }

        public ActionResult Index()
        {
            var contestViewModels = contestManagementService.GetAllContests();
            var contextCollectionViewModel = new ContextCollectionViewModel(contestViewModels);
            return View(contextCollectionViewModel);
        }
    }
}
