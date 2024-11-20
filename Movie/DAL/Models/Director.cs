using System.ComponentModel.DataAnnotations;

namespace Movies_project.DAL.Models
{
    public class Director
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Phone, Required]
        public string Contact { get; set; } = string.Empty;

        [EmailAddress, Required]
        public string Email { get; set; } = string.Empty;
        public ICollection<Movie>? Movies { get; set; } = new List<Movie>();
        public Nationality? Nationality { get; set; }
    }
}
