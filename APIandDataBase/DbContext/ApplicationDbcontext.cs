using APIandDataBase.IdentityAuth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIandDataBase.DbContext
{
    public class ApplicationDbcontext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            GiveRoles(builder);
        }

        private static void GiveRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
                (
                new IdentityRole() { Name = "admin", ConcurrencyStamp = "1", NormalizedName = "admin" },
                new IdentityRole() { Name = "user", ConcurrencyStamp = "2", NormalizedName = "user" }
                );
        }
    }

}
