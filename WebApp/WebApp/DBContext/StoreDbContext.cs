using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using WebApp.Models;

namespace WebApp
{
    //Update-Database -configuration WebApp.Migrations.Configuration -Verbose -force
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class StoreDbContext : Repository.Pattern.Ef6.DataContext
    {
        //Update-Database -configuration WebApp.Migrations.Configuration -Verbose -force
        public StoreDbContext()
            : base("DefaultConnection")
        {
        }

        public static StoreDbContext Create()
        {
            return new StoreDbContext();
        }

        public DbSet<Users> User { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<MenuItems> MenuItems { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<PagePermissions> PagePermissions { get; set; }
        public DbSet<RolePermissions> RolePermissions { get; set; }
        public DbSet<UnHandledErrors> Errors  { get; set; }
    }
}