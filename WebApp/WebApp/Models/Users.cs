using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApp.Identity;

namespace WebApp.Models
{
    public class Users : IUser<long>, IDisposable
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUserManager manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
        public long Id { get; set; }
        [Display(Name = "Role")]
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Roles Role { get; set; }
        [Required(ErrorMessage = "User Name is required.")]
        [RegularExpression("^[a-zA-Z0-9_]*$", ErrorMessage = "Only alphanumeric and underscores are allowed in User Name field.")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage = "Please enter valid name.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [RegularExpression("[A-Za-z ]*", ErrorMessage = "Please enter valid name.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "City is required.")]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Phone Number is required.")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        
        [Display(Name = "Street Address")]
        public string Address { get; set; }
        public bool IsAccountVerified { get; set; }
        public string TempPassword { get; set; }
        public bool IsPasswordResetRequested { get; set; }
        [Display(Name = "Last Login")]
        public Nullable<DateTime> LastLogin { get; set; }
        public bool IsTrustedUser { get; set; }
        public int InvalidAttempts { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePic { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool IsActive { get; set; }

        public void Dispose()
        {

        }

    }
}