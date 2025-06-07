using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Movie_app_api.Models;

namespace Movie_app_api.DbContext
{
    public class MovieDbContext:IdentityDbContext<ApplicationUser>
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options): base(options)
        {
                
        }
        
    }
}
