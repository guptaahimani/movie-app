using Microsoft.AspNetCore.Identity;

namespace Movie_app_api.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
