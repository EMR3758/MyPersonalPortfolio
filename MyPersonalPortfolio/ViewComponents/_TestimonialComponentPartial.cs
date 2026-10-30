using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IViewComponentResult Invoke()
        { 
            var values = context.Testimonials.ToList();
            return View(values); 
        }
    }
}
