using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;
using MyPersonalPortfolio.DAL.Entities;

namespace MyPersonalPortfolio.Controllers
{
    public class SkillController : Controller
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            context.Skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = context.Skills.Find(id);

            if (value == null)
                return NotFound();

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            var value = context.Skills.Find(skill.SkillId);
            if (value == null)
            {
                return NotFound();
            }
            value.Title = skill.Title;
            value.Value = skill.Value;

            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
