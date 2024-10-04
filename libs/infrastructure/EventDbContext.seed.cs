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
      Location = "Stadtpark, Hamburg",
      EventDate = new DateTime(2024, 6, 15, 14, 0, 0) // 15. Juni 2024, 14:00 Uhr
    });

    modelBuilder.Entity<Event>().HasData(
        new Event
        {
          Id = 2,
          Name = "Tech-Konferenz 2024",
          Description = "Die größte Tech-Konferenz in Europa mit Vorträgen von führenden Branchenexperten.",
          ImagePath = "/images/events/tech-konferenz2024.jpg",
          Location = "Messegelände, Berlin",
          EventDate = new DateTime(2024, 9, 10, 9, 0, 0) // 10. September 2024, 09:00 Uhr
        });

    modelBuilder.Entity<Event>().HasData(
        new Event
        {
          Id = 3,
          Name = "Kunst und Kultur Festival",
          Description = "Erleben Sie die Werke internationaler Künstler und genießen Sie kulturelle Darbietungen.",
          ImagePath = "/images/events/kunst-kultur-festival.jpg",
          Location = "Altstadt, München",
          EventDate = new DateTime(2024, 7, 20, 12, 0, 0) // 20. Juli 2024, 12:00 Uhr
        });

    modelBuilder.Entity<Event>().HasData(
        new Event
        {
          Id = 4,
          Name = "Winterwunderland Markt",
          Description = "Ein zauberhafter Weihnachtsmarkt mit Glühwein, Handwerkskunst und einer Eislaufbahn.",
          ImagePath = "/images/events/winterwunderland-markt.jpg",
          Location = "Schlossplatz, Dresden",
          EventDate = new DateTime(2024, 12, 1, 16, 0, 0) // 1. Dezember 2024, 16:00 Uhr
        });

    modelBuilder.Entity<Event>().HasData(
        new Event
        {
          Id = 5,
          Name = "Jazz Nacht 2024",
          Description = "Ein exklusives Jazz-Konzert mit bekannten internationalen Musikern.",
          ImagePath = "/images/events/jazz-nacht2024.jpg",
          Location = "Konzerthaus, Frankfurt",
          EventDate = new DateTime(2024, 11, 5, 19, 30, 0) // 5. November 2024, 19:30 Uhr
        });


  }
}
