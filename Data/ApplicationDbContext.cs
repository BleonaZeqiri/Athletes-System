using Microsoft.EntityFrameworkCore;
using AthleteSystem.Models;

namespace AthleteSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Performance> Performances { get; set; }
    }
}
