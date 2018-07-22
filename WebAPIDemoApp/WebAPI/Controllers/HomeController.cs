using System.Web.Mvc;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Default Home Controller
    /// </summary>
    /// <returns>Index.html</returns>
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
