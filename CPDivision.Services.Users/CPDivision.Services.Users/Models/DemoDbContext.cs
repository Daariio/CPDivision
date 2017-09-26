using System.IO;
using Microsoft.EntityFrameworkCore;

namespace CPDivision.Services.Users.Models
{
    public class DemoDbContext : DbContext
    {
        public DbSet<RToken> RTokens { get; set; }

        //public DbSet<AToken> ATokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = Path.Combine(Directory.GetCurrentDirectory(), "demo.db");

            optionsBuilder.UseInMemoryDatabase($"Data Source={connStr}");
        }
    }
}
