using EduSphere.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduSphere.Data.ViewModels
{
    public class NewCourseVM
    {
        public int Id { get; set; }

        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Course Image URL")]
        [Required(ErrorMessage = "Image URL is required")]
        public string ImageUrl { get; set; }

        [Display(Name = "Course Start Date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Course End Date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a Category")]
        [Required(ErrorMessage = "Course category is required")]
        public CourseCategory CourseCategory { get; set; }

        [Display(Name = "Select Teacher(s)")]
        [Required(ErrorMessage = "Course teacher(s) is required")]
        public List<int> TeacherIds { get; set; }

        [Display(Name = "Select a Company")]
        [Required(ErrorMessage = "Course company is required")]
        public int CompanyId { get; set; }
    }
}
