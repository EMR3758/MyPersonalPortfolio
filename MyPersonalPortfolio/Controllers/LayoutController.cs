using Microsoft.AspNetCore.Mvc;

namespace MyPersonalPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
