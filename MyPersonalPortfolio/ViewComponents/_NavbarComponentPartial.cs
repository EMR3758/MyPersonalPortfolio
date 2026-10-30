using Microsoft.AspNetCore.Mvc;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
