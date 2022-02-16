#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Recipes.Data;
using Recipes.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Recipes.Controllers
{
    public class RecipesController : Controller
    {
        private readonly RecipesContext _context;

        public RecipesController(RecipesContext context)
        {
            _context = context;
        }

        // GET: All Recipes
        public async Task<IActionResult> Index(string recipeDifficulty, string recipeDietaryRequirements, string searchString)
        {
            // Use LINQ to get list of difficulty.
            IQueryable<string> difficultyQuery = from t in _context.Recipe
                                             orderby t.Difficulty
                                             select t.Difficulty;

            // Use LINQ to get list of dietarary requirments.
            IQueryable<string> dietaryRequirementsQuery = from t in _context.Recipe
                                               orderby t.DietaryRequirements
                                               select t.DietaryRequirements;

            var recipe = from r in _context.Recipe
                         select r;

            if (!String.IsNullOrEmpty(searchString))
            {
                recipe = recipe.Where(s => s.Name!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(recipeDifficulty))
            {
                recipe = recipe.Where(x => x.Difficulty == recipeDifficulty);
            }

            if (!string.IsNullOrEmpty(recipeDietaryRequirements))
            {
                recipe = recipe.Where(x => x.DietaryRequirements == recipeDietaryRequirements);
            }

            var recipeDifficultyDietaryRequirementsVM = new RecipeDifficultyDietaryRequirementsViewModel
            {
                Difficulties = new SelectList(await difficultyQuery.Distinct().ToListAsync()),
                DietaryRequirements = new SelectList(await dietaryRequirementsQuery.Distinct().ToListAsync()),
                Recipes = await recipe.ToListAsync()
            };
            return View(recipeDifficultyDietaryRequirementsVM);
        }

        // GET: Healthy Recipes
        public async Task<IActionResult> HealthyRecipes(string recipeDifficulty, string recipeDietaryRequirements, string searchString)
            {
                // Use LINQ to get list of difficulty.
                IQueryable<string> difficultyQuery = from t in _context.Recipe
                                                     orderby t.Difficulty
                                                     select t.Difficulty;

                // Use LINQ to get list of dietarary requirments.
                IQueryable<string> dietaryRequirementsQuery = from t in _context.Recipe
                                                              orderby t.DietaryRequirements
                                                              select t.DietaryRequirements;

                var recipe = from r in _context.Recipe
                             select r;

                if (!String.IsNullOrEmpty(searchString))
                {
                    recipe = recipe.Where(s => s.Name!.Contains(searchString));
                }

                if (!string.IsNullOrEmpty(recipeDifficulty))
                {
                    recipe = recipe.Where(x => x.Difficulty == recipeDifficulty);
                }

                if (!string.IsNullOrEmpty(recipeDietaryRequirements))
                {
                    recipe = recipe.Where(x => x.DietaryRequirements == recipeDietaryRequirements);
                }

                var recipeDifficultyDietaryRequirementsVM = new RecipeDifficultyDietaryRequirementsViewModel
                {
                    Difficulties = new SelectList(await difficultyQuery.Distinct().ToListAsync()),
                    DietaryRequirements = new SelectList(await dietaryRequirementsQuery.Distinct().ToListAsync()),
                    Recipes = await recipe.ToListAsync()
                };

                return View(recipeDifficultyDietaryRequirementsVM);
            }

        // GET: All Recipes
        public async Task<IActionResult> QuickEasyRecipes(string recipeDifficulty, string recipeDietaryRequirements, string searchString)
        {
            // Use LINQ to get list of difficulty.
            IQueryable<string> difficultyQuery = from t in _context.Recipe
                                                 orderby t.Difficulty
                                                 select t.Difficulty;

            // Use LINQ to get list of dietarary requirments.
            IQueryable<string> dietaryRequirementsQuery = from t in _context.Recipe
                                                          orderby t.DietaryRequirements
                                                          select t.DietaryRequirements;

            var recipe = from r in _context.Recipe
                         select r;

            if (!String.IsNullOrEmpty(searchString))
            {
                recipe = recipe.Where(s => s.Name!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(recipeDifficulty))
            {
                recipe = recipe.Where(x => x.Difficulty == recipeDifficulty);
            }

            if (!string.IsNullOrEmpty(recipeDietaryRequirements))
            {
                recipe = recipe.Where(x => x.DietaryRequirements == recipeDietaryRequirements);
            }

            var recipeDifficultyDietaryRequirementsVM = new RecipeDifficultyDietaryRequirementsViewModel
            {
                Difficulties = new SelectList(await difficultyQuery.Distinct().ToListAsync()),
                DietaryRequirements = new SelectList(await dietaryRequirementsQuery.Distinct().ToListAsync()),
                Recipes = await recipe.ToListAsync()
            };

            return View(recipeDifficultyDietaryRequirementsVM);
        }

        // GET: Recipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // GET: Recipes/Create
        public IActionResult Create()
        {
            var model = new Recipe();
            return View(model);
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Image,Description,TimeToMake,Difficulty,Healthy,DietaryRequirements,Servings,Ingredients,Method")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipe);
                await _context.SaveChangesAsync();
                TempData["success"] = "Recipe created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(recipe);
        }

        // GET: Recipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipe.FindAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }

        // POST: Recipes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Image,Description,TimeToMake,Difficulty,Healthy,DietaryRequirements,Servings,Ingredients,Method")] Recipe recipe)
        {
            if (id != recipe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {                
                try
                {
                    _context.Update(recipe);
                    await _context.SaveChangesAsync();
                    TempData["success"] = "Recipe updated successfully";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipeExists(recipe.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(recipe);
        }

        // GET: Recipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // POST: Recipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipe = await _context.Recipe.FindAsync(id);
            _context.Recipe.Remove(recipe);
            await _context.SaveChangesAsync();
            TempData["success"] = "Recipe deleted successfully";
            return RedirectToAction(nameof(Index));
        }

        private bool RecipeExists(int id)
        {
            return _context.Recipe.Any(e => e.Id == id);
        }
    }
}
