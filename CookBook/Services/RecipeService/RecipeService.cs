using CookBook.Data;
using CookBook.Models;

namespace CookBook.Services.RecipeService
{
    public class RecipeService : IRecipeService
    {
        
        private DataContext _context;

        public RecipeService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Recipe>> AddRecipe(Recipe recipe)
        {
            _context.Recipes.Add(recipe);

            await _context.SaveChangesAsync();
            return await _context.Recipes.ToListAsync();
        }

        public async Task<List<Recipe>> DeleteRecipe(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null)
                return null;

            _context.Recipes.Remove(recipe);
            await _context.SaveChangesAsync();
            return await _context.Recipes.ToListAsync();
        }

        public async Task<List<Recipe>> GetAllRecipes()
        {
            var recipes = await _context.Recipes.ToListAsync();
            return recipes;
        }

        public async Task<Recipe> GetSingleRecipe(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null)
                return null;
            return recipe;
        }

        public async Task<List<Recipe>> UpdateRecipe(Recipe request, int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null)
                return null;

            recipe.RecipeName = request.RecipeName;
            recipe.NumPers = request.NumPers;
            recipe.Time = request.Time;
            recipe.Ingredients = request.Ingredients;
            recipe.Instructions = request.Instructions;
            recipe.Image = request.Image;

            await _context.SaveChangesAsync();

            return await _context.Recipes.ToListAsync();
        }
    }
}
