using Microsoft.EntityFrameworkCore;
using projetPromamec.Models;

namespace projetPromamec.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Project> Projects { get; set; }
    }
}