using CookBook.Models;

namespace CookBook.Services.RecipeService
{
    public class RecipeService : IRecipeService
    {
        private static List<Recipe> listRecipes = new List<Recipe> {
                new Recipe{
                    RecipeId = 1,
                    RecipeName="Pancakes"
                },
                new Recipe{
                    RecipeId=2,
                    RecipeName="Waffles"
                },
                 new Recipe{
                     RecipeId=3,
                    RecipeName="eggs"
                }
        };
         
        public List<Recipe> AddRecipe(Recipe recipe)
        {
            listRecipes.Add(recipe);
            if (recipe == null)
                return null;
            return listRecipes;
        }

        public List<Recipe> DeleteRecipe(int id)
        {
            var recipe = listRecipes.Find(x => x.RecipeId == id);
            if (recipe == null)
                return null;

            listRecipes.Remove(recipe);

            return listRecipes;
        }

        public List<Recipe> GetAllRecipes()
        {
            return listRecipes;
        }

        public Recipe GetSingleRecipe(int id)
        {
            var recipe = listRecipes.Find(x => x.RecipeId == id);
            if (recipe == null)
                return null;
            return recipe;
        }

        public List<Recipe> UpdateRecipe(Recipe request, int id)
        {
            var recipe = listRecipes.Find(x => x.RecipeId == id);
            if (recipe == null)
                return null;

            recipe.RecipeName = request.RecipeName;
            recipe.NumPers = request.NumPers;
            recipe.Time = request.Time;
            recipe.Ingredients = request.Ingredients;
            recipe.Instructions = request.Instructions;
            recipe.Image = request.Image;

            return listRecipes;
        }
    }
}
