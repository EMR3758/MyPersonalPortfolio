using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;
using MyPersonalPortfolio.DAL.Entities;

namespace MyPersonalPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Features.ToList();
            return View(values);
        }

        public IActionResult DeleteFeature(int id)
        {
            var value = context.Features.Find(id);

            if (value == null)
                return NotFound();

            context.Features.Remove(value);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var value = context.Features.Find(id);

            if (value == null)
                return NotFound();

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            var value = context.Features.Find(feature.FeatureId);

            if (value == null)
                return NotFound();

            value.Title = feature.Title;
            value.Description = feature.Description;

            context.SaveChanges();

            return RedirectToAction("Index");
        }


    }    
}
