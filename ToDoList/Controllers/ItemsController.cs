using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ToDoList.Controllers
{
<<<<<<< HEAD
    public class ItemsController : Controller
    {
        private readonly ToDoListContext _db;
=======
  public class ItemsController : Controller
  {
    [HttpGet("/categories/{categoryId}/items/new")]
    public ActionResult New(int categoryId)
    {
      Category category = Category.Find(categoryId);
      return View(category);
    }
>>>>>>> bc97877db3d1f25e8851bff708f1363bcf281e62

        public ItemsController(ToDoListContext db)
        {
            _db = db;
        }

<<<<<<< HEAD
        public ActionResult Index()
        {
            List<Item> model = _db.Items.Include(items => items.Category).ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Item thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
            return View(thisItem);
        }

        public ActionResult Edit(int id)
        {
            var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
            ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
            return View(thisItem);
        }

        [HttpPost]
        public ActionResult Edit(Item item)
        {
            _db.Entry(item).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
            return View(thisItem);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
            _db.Items.Remove(thisItem);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
=======
    // // This will be helpful later
    // [HttpPost("/items/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Item.ClearAll();
    //   return View();
    // }
  }
}
>>>>>>> bc97877db3d1f25e8851bff708f1363bcf281e62
