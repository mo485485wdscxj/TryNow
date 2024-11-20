using Movies_project.BLL.Dtos.CategoryDtos;
using Movies_project.DAL.Models;
using Movies_project.DAL.Repositories.Interfaces;
using Movies_projects.DAL.Data;

namespace Movies_project.DAL.Repositories.Impelementions
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(CreateCategoryDto dto)
        {
            var category = new Category
            {
                Name = dto.Name,
            };
            _context.Add(category);
            return _context.SaveChanges() > 0;
        }

        public bool Update(int id, CreateCategoryDto dto)
        {
            try
            {
                var category = new Category
                {
                    Id = id,
                    Name = dto.Name,
                };
                _context.Update(category);
                return _context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
