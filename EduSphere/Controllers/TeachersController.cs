using EduSphere.Data.Services;
using EduSphere.Data.Services.Teachers;
using EduSphere.Data.Static;
using EduSphere.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EduSphere.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class TeachersController : Controller
    {
        private readonly ITeachersService _service;

        public TeachersController(ITeachersService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var teachers = await _service.GetAllAsync();
            return View(teachers);
        }

        // GET: Teachers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Specialization, Biography, PhoneNumber, EmailAddress, LinkedinProfileUrl, InstagramProfileUrl, FacebookProfileUrl")] Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }

            await _service.AddAsync(teacher);
            return RedirectToAction(nameof(Index));
        }

        // GET: Teachers/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var teacher = await _service.GetByIdAsync(id);
            if (teacher == null)
            {
                return View("NotFound");
            }
            return View(teacher);
        }

        // GET: Teachers/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var teacher = await _service.GetByIdAsync(id);
            if (teacher == null)
            {
                return View("NotFound");
            }
            return View(teacher);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName, ProfilePictureURL, Specialization, Biography, PhoneNumber, EmailAddress, LinkedinProfileUrl, InstagramProfileUrl, FacebookProfileUrl")] Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }

            await _service.UpdateAsync(id, teacher);
            return RedirectToAction(nameof(Index));
        }

        // GET: Teachers/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var teacher = await _service.GetByIdAsync(id);
            if (teacher == null)
            {
                return View("NotFound");
            }
            return View(teacher);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teacher = await _service.GetByIdAsync(id);
            if (teacher == null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
 