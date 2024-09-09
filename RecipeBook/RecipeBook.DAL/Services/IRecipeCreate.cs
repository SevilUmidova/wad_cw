using RecipeBook.DAL.Models;

namespace RecipeBook
{
    public interface IRecipeCreate
    {
        Task<Recipe> CreateRecipeAsync(Recipe recipe);
    }
}
