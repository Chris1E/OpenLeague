namespace OpenLeague.Web.Controllers
{
    using System;
    using System.Web.Mvc;

    using OpenLeague.Model.Services;
    using OpenLeague.Model.ViewModels;

    public class ContestListController : Controller
    {
        private readonly IContestManagementService contestManagementService;

        public ContestListController(IContestManagementService contestManagementService)
        {
            this.contestManagementService = contestManagementService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var contestViewModels = contestManagementService.GetAllContests();
            var contextCollectionViewModel = new ContextCollectionViewModel(contestViewModels);
            return View(contextCollectionViewModel);
        }

        [HttpPost]
        public ActionResult Delete(Guid contestId)
        {
            contestManagementService.DeleteById(contestId);
            return RedirectToRoute("Index");
        }
    }
}
