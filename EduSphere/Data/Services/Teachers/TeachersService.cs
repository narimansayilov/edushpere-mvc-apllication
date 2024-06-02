using EduSphere.Data.Base;
using EduSphere.Models;

namespace EduSphere.Data.Services.Teachers
{
    public class TeachersService : EntityBaseRepository<Teacher>, ITeachersService
    {
        public TeachersService(AppDbContext context) : base(context) { }
    }
}
