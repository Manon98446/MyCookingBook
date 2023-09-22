using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookBook.Models
{
    public class Recipe
    {
        [Key] public int RecipeId { get; set; }
        public string? RecipeName { get; set; }
        public string? Image { get; set; }
        public int Time { get; set; }
        public int NumPers { get; set; }
        public string? Ingredients { get; set; }
        public string? Instructions { get; set; }

        //Relations
        //public List<Recipe_User>? Recipes_Users { get; set; }

        //PlateType
        //public int PlateId { get; set; }
        //[ForeignKey("PlateId")]
       // public PlateType? PlateType { get; set; }
        
       // public int CookingStyleId {  get; set; }
       // [ForeignKey("CookingStyleId")]
        //public CookingStyle? CookingStyle { get; set; }



    }
}
