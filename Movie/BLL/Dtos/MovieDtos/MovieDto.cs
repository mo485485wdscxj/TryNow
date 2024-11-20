using Movies_project.BLL.Dtos.CategoryDtos;
using Movies_project.BLL.Dtos.DirectorDtos;

namespace Movies_project.BLL.Dtos.MovieDtos
{
    public class MovieDto
    {
        public string Title { get; set; } = string.Empty;
        public DateTime ReleaseYear { get; set; }

        public ICollection<DirectorDto>? Directors { get; set; }
        public ICollection<CategoryDto>? Categories { get; set; }
    }
}