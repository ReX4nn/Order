using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApplication2.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<OrderViewModel> Orders { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options) 
        {
            Database.EnsureCreated();
            
        }

    }
}
