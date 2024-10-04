using AngularDotnetDemo.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AngularDotnetDemo.Infrastructure;

public partial class EventDbContext : DbContext
{
  public EventDbContext()
  {
    var folder = Environment.SpecialFolder.LocalApplicationData;
    var path = Environment.GetFolderPath(folder);
    _dbPath = Path.Join(path, "events.db");
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlite($"Data Source={_dbPath}");

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Event>()
      .HasKey(e => e.Id);

    SeedData(modelBuilder);
  }

  public DbSet<Event> Events { get; set; }
  private readonly string _dbPath;
}

