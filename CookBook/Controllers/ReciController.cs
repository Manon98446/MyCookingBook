using CookBook.Models;
using CookBook.Services.RecipeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CookBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReciController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public ReciController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Recipe>>> GetAllRecipes()
        {
             
            return await _recipeService.GetAllRecipes();
        }

        [HttpGet("{id}")] //the parameter id is to find the right route to the desired recipe
        public async Task<ActionResult<Recipe>> GetSingleRecipe(int id)
        {
            var recipe =await _recipeService.GetSingleRecipe(id);
            if (recipe == null) 
                return NotFound("The recipe doesn't exist");
            return Ok(recipe);
        }

        [HttpPost] 
        public async Task<ActionResult<List<Recipe>>> AddRecipe(Recipe recipe)
        {
            var result = await _recipeService.AddRecipe(recipe);
            if (result == null)
                return NotFound("recipe not found");
            return Ok(result);
        }



        [HttpPut] //the parameter id is to find the right route to the desired recipe
        public async Task<ActionResult<List<Recipe>>> UpdateRecipe(Recipe request, int id)
        {
            var result = await _recipeService.UpdateRecipe(request, id);
            if (result == null)
                return NotFound("recipe not found");
            return Ok(result);
        }

        [HttpDelete("{id}")] 
        public async Task<ActionResult<List<Recipe>>> DeleteRecipe(int id)
        {
            var result =await _recipeService.DeleteRecipe(id);
            if (result == null)
                return NotFound("recipe not found");
            return Ok(result);
        }

    }
}
