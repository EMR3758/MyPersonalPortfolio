using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;
using MyPersonalPortfolio.DAL.Entities;

namespace MyPersonalPortfolio.Controllers
{
    public class ToDoListController : Controller
    {
        MyPersonelPortfolioContext context = new MyPersonelPortfolioContext();
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            ViewBag.Completed = context.ToDoLists.Count(x => x.Status);
            ViewBag.Pending = context.ToDoLists.Count(x => !x.Status);
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            var value = context.ToDoLists.Find(toDoList.ToDoListId);

            if (value == null)
            {
                return NotFound();
            }

            value.Title = toDoList.Title;
            value.ImageUrl = toDoList.ImageUrl;
            value.Date = toDoList.Date;
            value.Status = toDoList.Status;

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatus(int id)
        {
            var value = context.ToDoLists.Find(id);

            if (value == null)
            {
                return NotFound();
            }

            value.Status = !value.Status;

            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
