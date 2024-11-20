﻿namespace Movies_project.DAL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Movie>? Movies { get; set; }
    }
}