using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AngularDotnetDemo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImagePath = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "ImagePath", "Location", "Name" },
                values: new object[,]
                {
                    { 1L, "Ein fröhliches Sommerfest mit Livemusik, Essen und Spielen für die ganze Familie.", "/images/events/sommerfest2024.jpg", "Stadtpark, Hamburg", "Sommerfest 2024" },
                    { 2L, "Die größte Tech-Konferenz in Europa mit Vorträgen von führenden Branchenexperten.", "/images/events/tech-konferenz2024.jpg", "Messegelände, Berlin", "Tech-Konferenz 2024" },
                    { 3L, "Erleben Sie die Werke internationaler Künstler und genießen Sie kulturelle Darbietungen.", "/images/events/kunst-kultur-festival.jpg", "Altstadt, München", "Kunst und Kultur Festival" },
                    { 4L, "Ein zauberhafter Weihnachtsmarkt mit Glühwein, Handwerkskunst und einer Eislaufbahn.", "/images/events/winterwunderland-markt.jpg", "Schlossplatz, Dresden", "Winterwunderland Markt" },
                    { 5L, "Ein exklusives Jazz-Konzert mit bekannten internationalen Musikern.", "/images/events/jazz-nacht2024.jpg", "Konzerthaus, Frankfurt", "Jazz Nacht 2024" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
