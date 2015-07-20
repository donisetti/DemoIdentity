using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace IdentityDemo.Models
{
    public class AppUserClaimsIdentityFactory : ClaimsIdentityFactory<AppUser>
    {
        public override async Task<ClaimsIdentity> CreateAsync(UserManager<AppUser, string> manager, AppUser user, string authenticationType)
        {
            var identity = await base.CreateAsync(manager, user, authenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Country, user.Estado));
            identity.AddClaim(new Claim("Idade", user.Idade.ToString()));
            return identity;
        }
    }
}