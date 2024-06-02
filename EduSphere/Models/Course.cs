using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduSphere.Data.Base;
using EduSphere.Data.Enums;

namespace EduSphere.Models
{
    public class Course : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Course Name is required")]
        public string Name { get; set; }

        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "Course Description is required")]
        public string Description { get; set; }

        [Display(Name = "Course ImageUrl")]
        public string ImageUrl { get; set; }

        [Display(Name = "Course Price")]
        [Required(ErrorMessage = "Course Price is required")]
        public double Price { get; set; }

        [Display(Name = "Course start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Course end date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Course Category")]
        public CourseCategory CourseCategory { get; set; }

        // Relationships
        public List<Teacher_Course> Teachers_Courses { get; set; }

        // Company
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}
