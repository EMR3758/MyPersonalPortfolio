using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPersonelPortfolioContext portfolioContext = new MyPersonelPortfolioContext();
        public IViewComponentResult Invoke() 
        { 
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=portfolioContext.Abouts.Select(x=> x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail=portfolioContext.Abouts.Select(x=> x.Details).FirstOrDefault();
               
            return View(); 
        }
    }
}
