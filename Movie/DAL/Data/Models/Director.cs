using System.ComponentModel.DataAnnotations;

namespace Movies_project.DAL.Data.Models
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
        public ICollection<Movie>? Movies { get; set; }
        public Nationality? Nationality { get; set; }
    }
}
