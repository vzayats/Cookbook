using System;
using System.ComponentModel.DataAnnotations;

namespace RecipesApp.DAL.Entities
{
    public class RecipeVersion
    {
        [Key]
        public int VersionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
        public string Type { get; set; }
        public string ImageLink { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string Notes { get; set; }

        public int? RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}