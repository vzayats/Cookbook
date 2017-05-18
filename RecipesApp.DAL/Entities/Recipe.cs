using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipesApp.DAL.Entities
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
        public string Type { get; set; }
        public string ImageLink { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Notes { get; set; }

        public ICollection<RecipeVersion> RecipeVersions { get; set; }

        public Recipe()
        {
            RecipeVersions = new List<RecipeVersion>();
        }
    }
}