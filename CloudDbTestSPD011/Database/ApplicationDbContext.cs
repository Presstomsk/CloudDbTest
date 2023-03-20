using CloudDbTestSPD011.Model;
using Microsoft.EntityFrameworkCore;

namespace CloudDbTestSPD011.Database;

public class ApplicationDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
    }
}