using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _SocialMediaComponentPartial : ViewComponent
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }
    }
}
