using EduSphere.Data.Base;using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduSphere.Models
{
    public class Teacher : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters")]
        public string FullName { get; set; }

        [Display(Name = "Specialization")]
        public string Specialization { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Biography { get; set; }

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Linkedin Profile")]
        [Url(ErrorMessage = "Invalid URL")]
        public string LinkedinProfileUrl { get; set; }

        [Display(Name = "Instagram Profile")]
        [Url(ErrorMessage = "Invalid URL")]
        public string InstagramProfileUrl { get; set; }

        [Display(Name = "Facebook Profile")]
        [Url(ErrorMessage = "Invalid URL")]
        public string FacebookProfileUrl { get; set; }

        // Relationships
        public List<Teacher_Course> Teachers_Courses { get; set; }
    }
}
