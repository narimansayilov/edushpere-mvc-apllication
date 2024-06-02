using EduSphere.Data;
using EduSphere.Data.Services;
using EduSphere.Data.Services.Courses;
using EduSphere.Data.Static;
using EduSphere.Data.ViewModels;
using EduSphere.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduSphere.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class CoursesController : Controller
    {
        private readonly ICoursesService _service;

        public CoursesController(ICoursesService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allCourses = await _service.GetAllAsync(n => n.Company);
            return View(allCourses);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allCourses = await _service.GetAllAsync(n => n.Company);

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredCourses = allCourses.Where(n => n.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase) || n.Description.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();

                return View("Index", filteredCourses);
            }

            return View("Index", allCourses);
        }

        //GET: Courses/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var courseDetail = await _service.GetCourseByIdAsync(id);
            return View(courseDetail);
        }

        //GET: Courses/Create
        public async Task<IActionResult> Create()
        {
            var courseDropdownsData = await _service.GetNewCourseDropdownsValues();

            ViewBag.Companies = new SelectList(courseDropdownsData.Companies, "Id", "Name");
            ViewBag.Teachers = new SelectList(courseDropdownsData.Teachers, "Id", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewCourseVM course)
        {
            if (!ModelState.IsValid)
            {
                var courseDropdownsData = await _service.GetNewCourseDropdownsValues();

                ViewBag.Companies = new SelectList(courseDropdownsData.Companies, "Id", "Name");
                ViewBag.Teachers = new SelectList(courseDropdownsData.Teachers, "Id", "FullName");

                return View(course);
            }

            await _service.AddNewCourseAsync(course);
            return RedirectToAction(nameof(Index));
        }


        //GET: Courses/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var courseDetails = await _service.GetCourseByIdAsync(id);
            if (courseDetails == null) return View("NotFound");

            var response = new NewCourseVM()
            {
                Id = courseDetails.Id,
                Name = courseDetails.Name,
                Description = courseDetails.Description,
                Price = courseDetails.Price,
                StartDate = courseDetails.StartDate,
                EndDate = courseDetails.EndDate,
                ImageUrl = courseDetails.ImageUrl,
                CourseCategory = courseDetails.CourseCategory,
                CompanyId = courseDetails.CompanyId,
                TeacherIds = courseDetails.Teachers_Courses.Select(n => n.TeacherId).ToList()
            };

            var courseDropdownsData = await _service.GetNewCourseDropdownsValues();
            ViewBag.Companies = new SelectList(courseDropdownsData.Companies, "Id", "Name");
            ViewBag.Teachers = new SelectList(courseDropdownsData.Teachers, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewCourseVM course)
        {
            if (id != course.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var courseDropdownsData = await _service.GetNewCourseDropdownsValues();

                ViewBag.Companies = new SelectList(courseDropdownsData.Companies, "Id", "Name");
                ViewBag.Teachers = new SelectList(courseDropdownsData.Teachers, "Id", "FullName");

                return View(course);
            }

            await _service.UpdateCourseAsync(course);
            return RedirectToAction(nameof(Index));
        }
    }
}
