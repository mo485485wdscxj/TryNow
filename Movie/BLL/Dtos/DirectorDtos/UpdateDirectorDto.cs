using Movies_project.BLL.Dtos.MovieDtos;
using Movies_project.BLL.Dtos.NationalityDtos;
using Movies_project.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace Movies_project.BLL.Dtos.DirectorDtos
{
    public class UpdateDirectorDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Phone, Required]
        public string Contact { get; set; } = string.Empty;

        [EmailAddress, Required]
        public string Email { get; set; } = string.Empty;
        public ICollection<UpdateMovieDto>? Movies { get; set; }
        public UpdateNationalityDto? Nationality { get; set; }
    }
}
