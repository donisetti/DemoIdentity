using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;

namespace IdentityDemo.Models
{
    public class AppUser : IdentityUser
    {
        public string Estado { get; set; }
        public int Idade { get; set; }
    }

    public class AppUserPrincipal : ClaimsPrincipal
    {
        public AppUserPrincipal(ClaimsPrincipal principal)
            : base(principal)
        {
        }

        public string Nome
        {
            get
            {
                return this.FindFirst(ClaimTypes.Name).Value;
            }
        }

        public string Estado
        {
            get
            {
                return this.FindFirst(ClaimTypes.Country).Value;
            }
        }

        public string Idade
        {
            get
            {
                return this.FindFirst("Idade").Value;
            }
        }

    }
}