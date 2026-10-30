using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IActionResult Inbox()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        public IActionResult MessageDetail(int id)
        {
            var value = context.Messages.FirstOrDefault(x => x.MessageId == id);

            if (value == null)
            {
                return NotFound();
            }

            if (!value.IsRead)
            {
                value.IsRead = true;
                context.SaveChanges();
            }

            return View(value);
        }

        public IActionResult ChangeStatus(int id)
        {
            var value = context.Messages.FirstOrDefault(x => x.MessageId == id);

            if (value == null)
            {
                return NotFound();
            }

            value.IsRead = !value.IsRead;

            context.SaveChanges();

            return RedirectToAction("Inbox");
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);

            if (value == null)
            {
                return NotFound();
            }

            context.Messages.Remove(value);
            context.SaveChanges();

            return RedirectToAction("Inbox");
        }
    }
}
