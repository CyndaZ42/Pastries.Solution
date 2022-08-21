using Microsoft.AspNetCore.Mvc;

namespace Pastries.Controllers
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