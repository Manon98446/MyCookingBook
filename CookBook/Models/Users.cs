using System.ComponentModel.DataAnnotations;

namespace CookBook.Models
{
    public class Users
    {
        [Key] public long UserId {  get; set; }
        public string UserName { get; set; }

        public string UserEmail { get; set; }
        public string Password { get; set; }

        //relations
        public List<Recipe_User>? Recipes_Users { get; set; }


    }
}
