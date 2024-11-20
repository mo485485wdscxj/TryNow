using Microsoft.EntityFrameworkCore;
using Movies_project.BLL.Dtos.CategoryDtos;
using Movies_project.BLL.Dtos.DirectorDtos;
using Movies_project.BLL.Dtos.MovieDtos;
using Movies_project.BLL.Dtos.NationalityDtos;
using Movies_project.DAL.Models;
using Movies_project.DAL.Repositories.Interfaces;
using Movies_projects.DAL.Data;

namespace Movies_project.DAL.Repositories.Impelementions
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(CreateMovieDto dto)
        {
            var movie = new Movie
            {
                Title = dto.Title,
                ReleaseYear = dto.ReleaseYear,
                Categories = dto.Categories.Select(x => new Category
                {
                    Name = x.Name,
                }).ToList(),
                Directors = dto.Directors.Select(x => new Director
                {
                    Contact = x.Contact,
                    Name = x.Name,
                    Email = x.Email,
                    Nationality = new Nationality
                    {
                        Name = x.Nationality.Name
                    }
                }).ToList(),
            };

            _context.Add(movie);

            return _context.SaveChanges() > 0;
        }

        public IEnumerable<MovieDto> getAll()
        {
            var books = _context.Movies
                .Include(x => x.Directors)
                .ThenInclude(x => x.Nationality)
                .Include(x => x.Categories)
                .Select(x => new MovieDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    ReleaseYear = x.ReleaseYear,
                    Categories = x.Categories.Select(c => new CategoryDto
                    {
                        Id = c.Id,
                        Name = c.Name,
                    }).ToList(),
                    Directors = x.Directors.Select(d => new DirectorDto
                    {
                        Id = d.Id,
                        Name = d.Name,
                        Contact = d.Contact,
                        Email = d.Email,
                        Nationality = new NationalityDto
                        {
                            Id = d.Nationality.Id,
                            Name = d.Nationality.Name,
                        }

                    }).ToList()
                }).ToList();

            return books;
        }

        public MovieDtoForOne? getById(int id)
        {
            var x = _context.Movies
                .Include(x => x.Directors)
                .ThenInclude(x => x.Nationality)
                .Include(x => x.Categories)
                .FirstOrDefault(x => x.Id == id);
            if (x is null)
                return null;

            return new MovieDtoForOne
            {
                Id = x.Id,
                Title = x.Title,
                ReleaseYear = x.ReleaseYear,
                Categories = x.Categories.Select(c => new CategoryDto
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList(),
                Directors = x.Directors.Select(d => new DirectorDtoForOne
                {
                    Id = d.Id,
                    Name = d.Name,
                    Contact = d.Contact,
                    Email = d.Email,
                    Nationality = new CreateNationalityDto
                    {
                        Name = d.Nationality.Name,
                    }
                }).ToList()
            };
        }
    }
}
