using AngularDotnetDemo.Core.Entities;

namespace AngularDotnetDemo.Infrastructure;

public partial class EventDbContext
{
  private void SeedData(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Event>().HasData(
    new Event
    {
      Id = 1,
      Name = "Sommerfest 2024",
      Description = "Ein fröhliches Sommerfest mit Livemusik, Essen und Spielen für die ganze Familie.",
      ImagePath = "/images/events/sommerfest2024.jpg",
      Location = "Stadtpark, Hamburg"
    });

    modelBuilder.Entity<Event>().HasData(
        new Event
        {
          Id = 2,
          Name = "Tech-Konferenz 2024",
          Description = "Die größte Tech-Konferenz in Europa mit Vorträgen von führenden Branchenexperten.",
          ImagePath = "/images/events/tech-konferenz2024.jpg",
          Location = "Messegelände, Berlin"
        });

    modelBuilder.Entity<Event>().HasData(
        new Event
        {
          Id = 3,
          Name = "Kunst und Kultur Festival",
          Description = "Erleben Sie die Werke internationaler Künstler und genießen Sie kulturelle Darbietungen.",
          ImagePath = "/images/events/kunst-kultur-festival.jpg",
          Location = "Altstadt, München"
        });

    modelBuilder.Entity<Event>().HasData(
        new Event
        {
          Id = 4,
          Name = "Winterwunderland Markt",
          Description = "Ein zauberhafter Weihnachtsmarkt mit Glühwein, Handwerkskunst und einer Eislaufbahn.",
          ImagePath = "/images/events/winterwunderland-markt.jpg",
          Location = "Schlossplatz, Dresden"
        });

    modelBuilder.Entity<Event>().HasData(
        new Event
        {
          Id = 5,
          Name = "Jazz Nacht 2024",
          Description = "Ein exklusives Jazz-Konzert mit bekannten internationalen Musikern.",
          ImagePath = "/images/events/jazz-nacht2024.jpg",
          Location = "Konzerthaus, Frankfurt"
        });

  }
}
