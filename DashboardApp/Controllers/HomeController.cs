using Microsoft.AspNetCore.Mvc;

namespace DashboardApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Azure DevOps Dashboard";

            return View();
        }
    }
}
