using System.ComponentModel.DataAnnotations;

namespace Movies_project.DAL.Data.Models
{
    public class Nationality
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public int? DirectorId { get; set; }
        public Director? Director { get; set; } = new Director();
    }
}
