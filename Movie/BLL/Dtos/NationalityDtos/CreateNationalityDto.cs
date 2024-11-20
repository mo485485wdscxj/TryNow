using System.ComponentModel.DataAnnotations;

namespace Movies_project.BLL.Dtos.NationalityDtos
{
    public class CreateNationalityDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
