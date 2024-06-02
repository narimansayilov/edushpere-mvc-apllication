using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EduSphere.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
    }
}
