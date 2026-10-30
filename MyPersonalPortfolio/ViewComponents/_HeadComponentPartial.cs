using Microsoft.AspNetCore.Mvc;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }

    }
}
