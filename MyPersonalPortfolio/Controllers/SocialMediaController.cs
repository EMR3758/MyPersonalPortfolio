using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;
using MyPersonalPortfolio.DAL.Entities;

namespace MyPersonalPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IActionResult Index()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            var value = context.SocialMedias.Find(socialMedia.SocialMediaId);
            value.Title = socialMedia.Title;
            value.Url = socialMedia.Url;
            value.Icon = socialMedia.Icon;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
