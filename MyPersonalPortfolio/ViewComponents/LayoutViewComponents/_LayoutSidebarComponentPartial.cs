using Microsoft.AspNetCore.Mvc;

namespace MyPersonalPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
