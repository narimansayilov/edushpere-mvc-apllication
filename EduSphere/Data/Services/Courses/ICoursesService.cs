using EduSphere.Data.Base;
using EduSphere.Data.ViewModels;
using EduSphere.Models;
using System.Threading.Tasks;

namespace EduSphere.Data.Services.Courses
{
    public interface ICoursesService : IEntityBaseRepository<Course>
    {
        Task<Course> GetCourseByIdAsync(int id);
        Task<NewCourseDropdownsVM> GetNewCourseDropdownsValues();        
        Task AddNewCourseAsync(NewCourseVM course);
        Task UpdateCourseAsync(NewCourseVM course);
    }
}