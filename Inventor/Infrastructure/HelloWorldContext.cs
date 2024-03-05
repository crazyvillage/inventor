using Microsoft.EntityFrameworkCore;

namespace CrazyVillage.Inventor.Infrastructure;

public class HelloWorldContext : DbContext
{
    public DbSet<Label> Labels { get; set; } = null!;

    public HelloWorldContext(DbContextOptions<HelloWorldContext> contextOptions)
    {
        
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=hello_world;Username=postgres")
            .UseSnakeCaseNamingConvention();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Label>()
            .HasData(new Label { Id = 1, Text = "Hello World!" });
    }
}