using Movies_project.BLL.Dtos.CategoryDtos;
using Movies_project.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace Movies_project.BLL.Dtos.MovieDtos
{
    public class UpdateMovieDto
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public DateTime ReleaseYear { get; set; }

        public ICollection<UpdateCategoryDto>? Categories { get; set; }
    }
}
