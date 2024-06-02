using EduSphere.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduSphere.Models
{
    public class Company : IEntityBase
    {
        public int Id { get; set; }

        [Display(Name = "Company Logo")]
        [Required(ErrorMessage = "Company logo is required")]
        public string Logo { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Website Address")]
        [Url(ErrorMessage = "Invalid website URL")]
        public string WebsiteAddress { get; set; }

        // Relationships
        public List<Course> Courses { get; set; }
    }
}
