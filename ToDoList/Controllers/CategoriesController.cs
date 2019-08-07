using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Controllers
{
  public class CategoriesController : Controller
  {
<<<<<<< HEAD
    private readonly ToDoListContext _db;

    public CategoriesController(ToDoListContext db)
    {
      _db = db;
    }

=======
    [HttpGet("/categories")]
>>>>>>> bc97877db3d1f25e8851bff708f1363bcf281e62
    public ActionResult Index()
    {
      List<Category> model = _db.Categories.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Category category)
    {
      _db.Categories.Add(category);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Category thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      return View(thisCategory);
    }

    public ActionResult Edit(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      return View(thisCategory);
    }

<<<<<<< HEAD
    [HttpPost]
    public ActionResult Edit(Category category)
    {
      _db.Entry(category).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      return View(thisCategory);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      _db.Categories.Remove(thisCategory);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
=======
    [HttpPost("/categories/{categoryId}/items/delete")]
    public ActionResult Delete(int categoryId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category selectedCategory = Category.Find(categoryId);
      List<Item> categoryItems = selectedCategory.Items;
      Item.ClearAll();
      return View("Show", model);
    }

>>>>>>> bc97877db3d1f25e8851bff708f1363bcf281e62
  }
}