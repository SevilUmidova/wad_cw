using RecipeBook.DAL.Data;
using RecipeBook.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.DAL.Services
{
    public class RecipeCreate : IRecipeCreate
    {
        private readonly ApplicationDbContext _context;

        public RecipeCreate(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Recipe> CreateRecipeAsync(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            await _context.SaveChangesAsync(); 
            return recipe;
        }
    }
}
