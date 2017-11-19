using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApp.Models;
using WebApp.Identity;

namespace WebApp
{
    //Only Identity related entries needed
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

    public class ApplicationDbContext : DbContext
    {
        //Update-Database -configuration WebApp.Migrations.Configuration -Verbose -force
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Users> User { get; set; }
        public DbSet<Roles> Role { get; set; }
        public DbSet<MenuItems> MenuItems { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<PagePermissions> PagePermissions { get; set; }
        public DbSet<RolePermissions> RolePermissions { get; set; }
    }
}