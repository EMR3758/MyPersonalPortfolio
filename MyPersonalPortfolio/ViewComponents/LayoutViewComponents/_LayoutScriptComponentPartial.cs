using Microsoft.AspNetCore.Mvc;

namespace MyPersonalPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
