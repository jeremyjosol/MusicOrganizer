using Microsoft.AspNetCore.Mvc;

namespace SpotifyClone.Controllers
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