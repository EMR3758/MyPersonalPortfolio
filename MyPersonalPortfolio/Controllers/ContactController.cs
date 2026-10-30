using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;
using MyPersonalPortfolio.DAL.Entities;

namespace MyPersonalPortfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();

        public IActionResult Index()
        {
            var value = context.Contacts.FirstOrDefault();
            return View(value);
        }

        [HttpGet]
        public IActionResult UpdateContact()
        {
            var value = context.Contacts.FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            var value = context.Contacts.Find(contact.ContactId);

            value.Title = contact.Title;
            value.Description = contact.Description;
            value.Phone1 = contact.Phone1;
            value.Phone2 = contact.Phone2;
            value.Email1 = contact.Email1;
            value.Email2 = contact.Email2;
            value.Address = contact.Address;

            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
