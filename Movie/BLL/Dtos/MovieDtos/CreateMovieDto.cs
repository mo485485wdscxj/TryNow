using Movies_project.BLL.Dtos.CategoryDtos;
using Movies_project.BLL.Dtos.DirectorDtos;
using System.ComponentModel.DataAnnotations;

namespace Movies_project.BLL.Dtos.MovieDtos
{
    public class CreateMovieDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        public DateTime ReleaseYear { get; set; }

        public ICollection<CreateDirectoryDto>? Directors { get; set; }
        public ICollection<CreateCategoryDto>? Categories { get; set; }
    }
}
