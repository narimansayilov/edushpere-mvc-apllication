using EduSphere.Data.Base;
using EduSphere.Models;

namespace EduSphere.Data.Services
{
    public class CompaniesService : EntityBaseRepository<Company>, ICompaniesService
    {
        public CompaniesService(AppDbContext context) : base(context) { }
    }
}
