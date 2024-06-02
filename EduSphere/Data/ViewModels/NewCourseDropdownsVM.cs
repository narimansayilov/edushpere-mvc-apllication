using EduSphere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace EduSphere.Data.ViewModels
{
    public class NewCourseDropdownsVM
    {
        public NewCourseDropdownsVM()
        {
            Companies = new List<Company>();
            Teachers = new List<Teacher>();
        }

        public List<Company> Companies { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}