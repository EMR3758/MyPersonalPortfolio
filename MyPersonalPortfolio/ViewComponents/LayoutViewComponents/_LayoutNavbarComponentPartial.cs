using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IViewComponentResult Invoke() 
        { 
            ViewBag.toDoListCount = context.ToDoLists.Where(x=>x.Status==false).Count();
            var values = context.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values); 
        }
    }
}
