using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IViewComponentResult Invoke() 
        {
            var value = context.Contacts.FirstOrDefault();
            return View(value); 
        }
    }
}
