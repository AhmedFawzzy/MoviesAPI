using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace MoviesAPI.Data
{
    public class DataContext:IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options ):base(options) 
        {
            
        }

       public DbSet<Genre> genres { get; set; }
       public DbSet<Movie> movies { get; set; }
    }
}
