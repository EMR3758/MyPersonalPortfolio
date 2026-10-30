using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IViewComponentResult Invoke() 
        {
            var values = context.Experiences.ToList();
            return View(values); 
        
        }
    }
}
