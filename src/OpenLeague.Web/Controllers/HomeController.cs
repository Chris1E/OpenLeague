namespace OpenLeague.Web.Controllers
{
    using System.Web.Mvc;

    using OpenLeague.Model.Services;

    public class HomeController : Controller
    {
        private readonly IContestManagementService contestManagementService;

        public HomeController(IContestManagementService contestManagementService)
        {
            this.contestManagementService = contestManagementService;
        }

        public ActionResult Index()
        {
            var contestViewModels = contestManagementService.GetAllContests();
            return View(contestViewModels);
        }
    }
}
