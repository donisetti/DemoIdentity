using IdentityDemo.Models;
using System.Security.Claims;
using System.Web.Mvc;

namespace IdentityDemo.Controllers
{
    public abstract class AppController : Controller
    {
        public AppUserPrincipal CurrentUser
        {
            get
            {
                return new AppUserPrincipal(User as ClaimsPrincipal);
            }
        }
    }
}