using Microsoft.EntityFrameworkCore;
using PopCulture.Models;

namespace PopCulture.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<WearType> WearTypes { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
