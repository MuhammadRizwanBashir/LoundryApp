using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class RolesViewModels
    {
        public Roles Roles { get; set; }
        public IEnumerable<Roles> RolesList { get; set; }
    }
}