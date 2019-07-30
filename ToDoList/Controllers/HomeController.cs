using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
// using Microsoft.AspNetCore.Mvc;
// //using System.Collections.Generic;

// namespace ToDoList.Controllers
// {
//   public class HomeController : Controller
//   {

//     [HttpGet("/")]
//     public ActionResult Index()
//     {
//     //   Item starterItem = new Item("Add first item to To Do List");
//       return View();
//     }

//     [HttpGet("/items/new")]
//     public ActionResult CreateForm()
//     {
//       return View();
//     }

//     [HttpPost("/items")]
//     public ActionResult Create(string description)
//     {
//       Item myItem = new Item(description);
//       return RedirectToAction("Index");
//     }

//     [Route("/favorite_photos")]
//     public ActionResult FavoritePhotos()
//     {
//         return View();
//     }

//   }
// }