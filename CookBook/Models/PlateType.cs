using System.ComponentModel.DataAnnotations;

namespace CookBook.Models
{
    public class PlateType
    {
        [Key] public long PlateId { get; set; }
        public string? PlateName { get; set; }

        //Relationships
        public List<Recipe>? Recipes { get; set; }
    }
}
