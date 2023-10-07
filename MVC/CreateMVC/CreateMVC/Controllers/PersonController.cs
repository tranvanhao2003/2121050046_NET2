using Microsoft.AspNetCore.Mvc;

namespace CreateMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
