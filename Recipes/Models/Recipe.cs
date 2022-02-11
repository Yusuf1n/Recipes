using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipes.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public string Description { get; set; }
        public string TimeToMake { get; set; }
        
        public string Difficulty { get; set; }
        [NotMapped]
        public List<SelectListItem> DifficultyList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "More effort", Text = "More effort" },
            new SelectListItem { Value = "Not too tricky", Text = "Not too tricky" },
            new SelectListItem { Value = "Easy", Text = "Easy" },
            new SelectListItem { Value = "Super easy", Text = "Super easy" }
        };

        public bool Healthy { get; set; }

        public string DietaryRequirements { get; set; }
        [NotMapped]
        public List<SelectListItem> DietaryRequirementsList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Vegetarian", Text = "Vegetarian" },
            new SelectListItem { Value = "Vegan", Text = "Vegan" },
            new SelectListItem { Value = "Gluten-Free", Text = "Gluten-Free" }
        };

        public string Servings { get; set; }
        public string Ingredients { get; set; }
        public string Method { get; set; } 
    }
}
