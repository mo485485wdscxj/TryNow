using Movies_project.BLL.Dtos.NationalityDtos;
using System.ComponentModel.DataAnnotations;

namespace Movies_project.BLL.Dtos.DirectorDtos
{
    public class CreateDirectoryDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Phone, Required]
        public string Contact { get; set; } = string.Empty;

        [EmailAddress, Required]
        public string Email { get; set; } = string.Empty;

        public CreateNationalityDto? Nationality { get; set; }
    }
}
