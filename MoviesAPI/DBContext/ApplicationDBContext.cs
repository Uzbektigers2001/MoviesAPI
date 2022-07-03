using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Movie>? movies { get; set; }
    }
}
