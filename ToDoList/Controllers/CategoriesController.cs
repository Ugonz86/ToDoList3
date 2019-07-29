using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class CategoriesController : Controller
  {

    [HttpPost("/categories/{categoryId}/items")]
    public ActionResult Create(int categoryId, string itemDescription)
    {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Category foundCategory = Category.Find(categoryId);
    Item newItem = new Item(itemDescription);
    foundCategory.AddItem(newItem);
    List<Item> categoryItems = foundCategory.Items;
    model.Add("items", categoryItems);
    model.Add("category", foundCategory);
    return View("Show", model);
    }

  }
}