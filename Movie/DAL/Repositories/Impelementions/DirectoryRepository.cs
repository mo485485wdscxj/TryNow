using Microsoft.EntityFrameworkCore;
using Movies_project.BLL.Dtos.DirectorDtos;
using Movies_project.DAL.Models;
using Movies_project.DAL.Repositories.Interfaces;
using Movies_projects.DAL.Data;

namespace Movies_project.DAL.Repositories.Impelementions
{
    public class DirectoryRepository : IDirectoryRepository
    {
        private readonly ApplicationDbContext _context;

        public DirectoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(CreateDirectoryDto dto)
        {
            var director = new Director
            {
                Email = dto.Email,
                Contact = dto.Contact,
                Name = dto.Name,
                Nationality = new Nationality
                {
                    Name = dto.Nationality.Name,
                },
            };
            _context.Add(director);

            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var director = _context.Directors.FirstOrDefault(x => x.Id == id);
            if (director is null)
                return false;
            _context.Remove(director);
            _context.SaveChanges();
            return true;
        }

        public bool Update(UpdateDirectorDto dto)
        {
            var director = _context.Directors
                .Include(x => x.Movies)
                .ThenInclude(x => x.Categories)
                .Include(x => x.Nationality)
                .FirstOrDefault(x => x.Id == dto.Id);

            if (director is null)
                return false;

            director.Name = dto.Name;
            director.Email = dto.Email;
            director.Contact = dto.Contact;
            director.Nationality = new Nationality
            {
                Id = dto.Nationality.Id,
                Name = dto.Nationality.Name,
            };
            director.Movies = dto.Movies.Select(x => new Movie
            {
                Id = x.Id,
                ReleaseYear = x.ReleaseYear,
                Title = x.Title,
                Categories = x.Categories.Select(x => new Category
                {
                    Id = x.Id,
                    Name = x.Name,
                }).ToList()
            }).ToList();

            _context.Update(director);
            return _context.SaveChanges() > 0;
        }
    }
}
