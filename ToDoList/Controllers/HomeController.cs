using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {

<<<<<<< HEAD
      [HttpGet("/favorite_photos")]
      public ActionResult FavoritePhotos()
      {
        return View();
      }

    }
}
=======
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}
>>>>>>> bc97877db3d1f25e8851bff708f1363bcf281e62
