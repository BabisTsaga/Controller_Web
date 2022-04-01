using Microsoft.EntityFrameworkCore;
using WebAppA.Models;

namespace WebAppA.Controllers.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}

