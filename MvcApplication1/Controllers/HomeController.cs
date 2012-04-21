using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
         public ViewResult Index()
         {
             ViewBag.Title = "Trying out Twitter Bootstrap";
             return View();
         }

        public ViewResult About()
        {
            ViewBag.Title = "Trying out Twitter Bootstrap";
            return View();
        }

        public ViewResult Contact()
        {
            ViewBag.Title = "Trying out Twitter Bootstrap";
            return View();
        }
    }
}