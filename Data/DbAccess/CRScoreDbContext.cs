using Microsoft.EntityFrameworkCore;
using CRScore.Models;

namespace CRScore.Data.DbAccess
{
    public class CRScoreDbContext : DbContext
    {
        public CRScoreDbContext(DbContextOptions<CRScoreDbContext> options) : base(options)
        {            
        }

        public DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Score>().ToTable("Score");
        }
    }
}
