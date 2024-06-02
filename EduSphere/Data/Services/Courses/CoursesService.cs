using EduSphere.Data.Base;
using EduSphere.Data.Enums;
using EduSphere.Data.ViewModels;
using EduSphere.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading.Tasks;

namespace EduSphere.Data.Services.Courses
{
    public class CoursesService : EntityBaseRepository<Course>, ICoursesService
    {
        private readonly AppDbContext _context;

        public CoursesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewCourseAsync(NewCourseVM course)
        {
            var newCourse = new Course()
            {
                Name = course.Name,
                Description = course.Description,
                Price = course.Price,
                ImageUrl = course.ImageUrl,
                StartDate = course.StartDate,
                EndDate = course.EndDate,
                CourseCategory = course.CourseCategory,
                CompanyId = course.CompanyId
            };
            await _context.Courses.AddAsync(newCourse);
            await _context.SaveChangesAsync();

            // Add Course Teachers
            foreach ( var teacherId in course.TeacherIds)
            {
                var newTeacherCourse = new Teacher_Course()
                {
                    CourseId = newCourse.Id,
                    TeacherId = teacherId
                };
                await _context.Teachers_Courses.AddAsync(newTeacherCourse);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            var courseDetails = await _context.Courses
                .Include(c => c.Company)
                .Include(tc => tc.Teachers_Courses).ThenInclude(t => t.Teacher)
                .FirstOrDefaultAsync(n => n.Id == id);

            return courseDetails;
        }

        public async Task<NewCourseDropdownsVM> GetNewCourseDropdownsValues()
        {
            var response = new NewCourseDropdownsVM()
            {
                Teachers = await _context.Teachers.OrderBy(n => n.FullName).ToListAsync(),
                Companies = await _context.Companies.OrderBy(n => n.Name).ToListAsync()
            };

            return response;
        }

        public async Task UpdateCourseAsync(NewCourseVM course)
        {
            var dbCourse = await _context.Courses.FirstOrDefaultAsync(n => n.Id == course.Id);

            if(dbCourse != null)
            {
                dbCourse.Name = course.Name;
                dbCourse.Description = course.Description;
                dbCourse.Price = course.Price;
                dbCourse.ImageUrl = course.ImageUrl;
                dbCourse.StartDate = course.StartDate;
                dbCourse.EndDate = course.EndDate;
                dbCourse.CourseCategory = course.CourseCategory;
                dbCourse.CompanyId = course.CompanyId;
                await _context.SaveChangesAsync();
            }

            // Remove existing teachers
            var existingTeachersDb = _context.Teachers_Courses.Where(n => n.CourseId == course.Id).ToList();
            _context.Teachers_Courses.RemoveRange(existingTeachersDb);
            await _context.SaveChangesAsync();

            // Add Course Teachers
            foreach (var teacherId in course.TeacherIds)
            {
                var newTeacherCourse = new Teacher_Course()
                {
                    CourseId = course.Id,
                    TeacherId = teacherId
                };
                await _context.Teachers_Courses.AddAsync(newTeacherCourse);
            }
            await _context.SaveChangesAsync(); 
        }
    }
}