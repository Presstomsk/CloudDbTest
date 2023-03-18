using Microsoft.EntityFrameworkCore;

namespace CloudDbTestSPD011.Model;
/// <summary>
/// Контекст данных
/// </summary>
public class ApplicationDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    public DbSet<Course> Courses { get; set; }

    // конфигурация контекста
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
    }
}