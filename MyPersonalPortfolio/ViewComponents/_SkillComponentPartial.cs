 using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyPersonelPortfolioContext portfolioContext = new MyPersonelPortfolioContext();
        public IViewComponentResult Invoke() 
        {
            var values = portfolioContext.Skills.ToList();
            return View(values); 
        
        }
    }
}
