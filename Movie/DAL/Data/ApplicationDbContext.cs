using Microsoft.EntityFrameworkCore;
using Movies_project.DAL.Models;

namespace Movies_projects.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>().HasOne(x=>x.Nationality).WithOne(x=>x.Director).OnDelete(DeleteBehavior.SetNull);
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
    }
}
