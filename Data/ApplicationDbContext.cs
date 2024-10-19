using Microsoft.EntityFrameworkCore;
using MulkyWebRazor.Model;

namespace MulkyWebRazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Category> Category { get; set; }
    }
}
