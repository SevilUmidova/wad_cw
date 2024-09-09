using Microsoft.AspNetCore.Mvc;
using RecipeBook.DAL.Models;

namespace RecipeBook.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeCreate _recipeService;

        public RecipeController(IRecipeCreate recipeService)
        {
            _recipeService = recipeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                await _recipeService.CreateRecipeAsync(recipe);
                return RedirectToAction(nameof(Create)); 
            }
            return View(recipe);  
        }
    }
}
