using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;
using MyPersonalPortfolio.DAL.Entities;

namespace MyPersonalPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            message.IsRead = false;

            context.Messages.Add(message);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
