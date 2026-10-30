using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.Controllers
{
    public class StatisticController : Controller
    {
       MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();

        public IActionResult Index()
        {
            // İstatistik Kartları
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Count(x => !x.IsRead);
            ViewBag.v4 = context.Messages.Count(x => x.IsRead);
            ViewBag.v5 = context.Experiences.Count();
            ViewBag.v6 = context.Portfolios.Count();
            ViewBag.v7 = context.Testimonials.Count();
            ViewBag.v8 = context.SocialMedias.Count();

            // Son Eklenen Deneyimler
            ViewBag.LastExperiences = context.Experiences
                .OrderByDescending(x => x.ExperienceId)
                .Take(5)
                .ToList();

            // Son Gelen Mesajlar
            ViewBag.LastMessages = context.Messages
                .OrderByDescending(x => x.SendDate)
                .Take(3)
                .ToList();

            return View();
        }
    }
}