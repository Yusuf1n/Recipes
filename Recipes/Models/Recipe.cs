using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipes.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [StringLength(60)]
        [Display(Name = "Recipe")]
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }

        [StringLength(200)]
        [Required]
        public string Description { get; set; }

        [StringLength(15)]
        [Display(Name = "Time To Make")]
        [Required]
        public string TimeToMake { get; set; }
        
        public string Difficulty { get; set; }

        [NotMapped]
        public List<SelectListItem> DifficultyList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Challenging", Text = "Challenging" },
            new SelectListItem { Value = "More effort", Text = "More effort" },
            new SelectListItem { Value = "Not too tricky", Text = "Not too tricky" },
            new SelectListItem { Value = "Easy", Text = "Easy" },
            new SelectListItem { Value = "Super easy", Text = "Super easy" }
        };

        public bool Healthy { get; set; }

        [Display(Name = "Dietary Requirements")]
        public string DietaryRequirements { get; set; }
        
        [NotMapped]
        public List<SelectListItem> DietaryRequirementsList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "None", Text = "None" },
            new SelectListItem { Value = "Vegetarian", Text = "Vegetarian" },
            new SelectListItem { Value = "Vegan", Text = "Vegan" },
            new SelectListItem { Value = "Gluten-Free", Text = "Gluten-Free" }
        };

        [Required]
        [StringLength(2)]
        public string Servings { get; set; }

        [StringLength(1000)]
        [Required]
        public string Ingredients { get; set; }

        [StringLength(3000)]
        [Required]
        public string Method { get; set; } 
    }
}
