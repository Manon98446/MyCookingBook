
using Microsoft.EntityFrameworkCore;

namespace CookBook.Models

{
    [Keyless]
    public class Recipe_User
    {       
        public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }

        public int UserId { get; set; }
        public Users? User { get; set; }

    }
}
