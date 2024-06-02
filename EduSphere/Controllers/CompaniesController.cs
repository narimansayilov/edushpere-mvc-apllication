using EduSphere.Data.Services;
using EduSphere.Data.Static;
using EduSphere.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EduSphere.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class CompaniesController : Controller
    {
        private readonly ICompaniesService _service;

        public CompaniesController(ICompaniesService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allCompanies = await _service.GetAllAsync();
            return View(allCompanies);
        }

        // GET: Companies/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description,Address,EmailAddress,PhoneNumber,WebsiteAddress")] Company company)
        {
            if (!ModelState.IsValid) return View(company);
            await _service.AddAsync(company);
            return RedirectToAction(nameof(Index));
        }

        // GET: Companies/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var companyDetails = await _service.GetByIdAsync(id);
            if (companyDetails == null) return View("NotFound");
            return View(companyDetails);
        }

        // GET: Companies/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var companyDetails = await _service.GetByIdAsync(id);
            if (companyDetails == null) return View("NotFound");
            return View(companyDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description,Address,EmailAddress,PhoneNumber,WebsiteAddress")] Company company)
        {
            if (!ModelState.IsValid) return View(company);
            await _service.UpdateAsync(id, company);
            return RedirectToAction(nameof(Index));
        }

        // GET: Companies/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var companyDetails = await _service.GetByIdAsync(id);
            if (companyDetails == null) return View("NotFound");
            return View(companyDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var companyDetails = await _service.GetByIdAsync(id);
            if (companyDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
