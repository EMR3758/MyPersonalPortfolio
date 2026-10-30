using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.PortfolioCount = context.Portfolios.Count();
            ViewBag.SkillCount = context.Skills.Count();
            ViewBag.ExperienceCount = context.Experiences.Count();
            ViewBag.MessageCount = context.Messages.Count();
            return View();
        }
    }
}
