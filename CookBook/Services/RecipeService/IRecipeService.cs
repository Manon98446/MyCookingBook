namespace CookBook.Services.RecipeService
{
    public interface IRecipeService
    {
        List<Recipe> GetAllRecipes();
        Recipe GetSingleRecipe(int id);
        List<Recipe> AddRecipe(Recipe recipe);
        List<Recipe> UpdateRecipe(Recipe request, int id);
        List<Recipe> DeleteRecipe(int id);
    }
}
