using System.ComponentModel.DataAnnotations;

namespace CookBook.Models
{
    public class CookingStyle
    {
        [Key] public long CookingStyleId {  get; set; }
        public string? CookingStyleName {  get; set; }

        //Relationships
        public List<Recipe>? Recipes { get; set; }
    }
}
