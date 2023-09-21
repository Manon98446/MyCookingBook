namespace CookBook.Services.RecipeService
{
    public interface IRecipeService
    {
        Task<List<Recipe>> GetAllRecipes();
        Task<Recipe> GetSingleRecipe(int id);
        Task<List<Recipe>> AddRecipe(Recipe recipe);
        Task<List<Recipe>> UpdateRecipe(Recipe request, int id);
        Task<List<Recipe>> DeleteRecipe(int id);
    }
}
