using System.Security.Claims;
using System.Web.Mvc;

namespace IdentityDemo.Controllers
{

    public class HomeController : AppController
    {
        public ActionResult Index()
        {
            return View();
        }


    }
}