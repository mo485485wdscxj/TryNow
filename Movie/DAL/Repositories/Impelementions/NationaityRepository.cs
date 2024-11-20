using Movies_project.BLL.Dtos.NationalityDtos;
using Movies_project.DAL.Models;
using Movies_project.DAL.Repositories.Interfaces;
using Movies_projects.DAL.Data;

namespace Movies_project.DAL.Repositories.Impelementions
{
    public class NationaityRepository : INationaityRepository
    {
        private readonly ApplicationDbContext _context;

        public NationaityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(CreateNationalityDto dto)
        {
            var national = new Nationality
            {
                Name = dto.Name,
            };
            _context.Nationalities.Add(national);

            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var nationailty = _context.Nationalities.FirstOrDefault(x => x.Id == id);
            if (nationailty is null)
                return false;
            _context.Remove(nationailty);
            return _context.SaveChanges() > 0;
        }
    }
}
