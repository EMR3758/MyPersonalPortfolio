using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values); 
        }
    }
}
