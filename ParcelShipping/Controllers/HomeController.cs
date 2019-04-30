using Microsoft.AspNetCore.Mvc;

namespace ParcelController.Controllers
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
