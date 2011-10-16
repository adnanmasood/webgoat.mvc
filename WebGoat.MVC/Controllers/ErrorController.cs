using System.Web.Mvc;
using System.Web.UI;

namespace WebGoat.MVC.Controllers
{
    [HandleError]
    [OutputCache(Location = OutputCacheLocation.None)]
    public class ErrorController : Controller
    {
        public ActionResult Index(string error)
        {
            ViewData["Title"] = "Sorry, an error occurred while processing your request.";
            ViewData["Description"] = error;
            return View();
        }


        public ActionResult HttpError404(string error)
        {
            ViewData["Title"] = "Sorry, an error occurred while processing your request. (404)";
            ViewData["Description"] = error;
            return View("Index");
        }

        public ActionResult HttpError500(string error)
        {
            ViewData["Title"] = "Sorry, an error occurred while processing your request. (500)";
            ViewData["Description"] = error;
            return View("Index");
        }


        public ActionResult General(string error)
        {
            ViewData["Title"] = "Sorry, an error occurred while processing your request.";
            ViewData["Description"] = error;
            return View("Index");
        }


    }
}
