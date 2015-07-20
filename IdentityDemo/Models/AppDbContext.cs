using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IdentityDemo.Models
{
    public class AppDbContext :IdentityDbContext<AppUser>
    {
        public AppDbContext() :base("DefaultConnection")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>().ToTable("Usuario");
            modelBuilder.Entity<AppUser>().ToTable("Usuario");
        }
    }
}