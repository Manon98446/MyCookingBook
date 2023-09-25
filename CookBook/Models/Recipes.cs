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

        //Relations (many to many)
        public List<Users>? Users { get; set; }

        //PlateType (one to many)
        public int PlateTypeId { get; set; }
        public PlateType? PlateType { get; set; }
        
        //CookingStyle (one to many)
        public int CookingStyleId {  get; set; }
        public CookingStyle? CookingStyle { get; set; }



    }
}
