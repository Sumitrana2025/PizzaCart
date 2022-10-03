using Microsoft.AspNetCore.Identity;

namespace PizzaCart.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
    }
}
