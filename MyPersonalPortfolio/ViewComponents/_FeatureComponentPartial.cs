using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPersonelPortfolioContext portfoliocontext=new MyPersonelPortfolioContext();

        public IViewComponentResult Invoke() 
        {
            var values = portfoliocontext.Features.ToList();
            return View(values); 
        }

    }
}
