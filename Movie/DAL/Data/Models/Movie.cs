using System.ComponentModel.DataAnnotations;

namespace Movies_project.DAL.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public DateTime ReleaseYear { get; set; }

        public ICollection<Director>? Directors { get; set; }
        public ICollection<Category>? Categories { get; set; }
    }
}
