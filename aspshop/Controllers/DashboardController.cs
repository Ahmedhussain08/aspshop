using Microsoft.AspNetCore.Mvc;

namespace aspshop.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }  public IActionResult Dashboard()
        {
            return View();
        }
    }
}
