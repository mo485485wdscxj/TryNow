using Movies_project.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace Movies_project.BLL.Dtos.NationalityDtos
{
    public class UpdateNationalityDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
