using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;
using MyPersonalPortfolio.DAL.Entities;

namespace MyPersonalPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var testimonial = context.Testimonials.Find(id);
            if (testimonial != null)
            {
                context.Testimonials.Remove(testimonial);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var testimonial = context.Testimonials.Find(id);
            if (testimonial != null)
            {
                return View(testimonial);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var existingTestimonial = context.Testimonials.Find(testimonial.TestimonialId);
            if (existingTestimonial != null)
            {
                existingTestimonial.NameSurname = testimonial.NameSurname;
                existingTestimonial.Title = testimonial.Title;
                existingTestimonial.Comment = testimonial.Comment;
                existingTestimonial.ImageUrl = testimonial.ImageUrl;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
