using Movies_project.BLL.Dtos.MovieDtos;
using Movies_project.BLL.Dtos.NationalityDtos;
using Movies_project.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace Movies_project.BLL.Dtos.DirectorDtos
{
    public class DirectorDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Phone]
        public string Contact { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public NationalityDto? Nationality { get; set; }
    }
}
