using System.ComponentModel.DataAnnotations;

namespace Movies_project.BLL.Dtos.CategoryDtos
{
    public class CreateCategoryDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
