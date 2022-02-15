using Microsoft.AspNetCore.Mvc.Rendering;

namespace Recipes.Models
{
    public class RecipeDifficultyDietaryRequirementsViewModel
    {
        public List<Recipe>? Recipes { get; set; }
        public SelectList? Difficulties { get; set; }
        public string? RecipeDifficulty { get; set; }
        public SelectList? DietaryRequirements { get; set; }
        public string? RecipeDietaryRequirements { get; set; }
        public string? SearchString { get; set; }
    }
}
