﻿// <auto-generated />
using AngularDotnetDemo.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AngularDotnetDemo.Infrastructure.Migrations
{
    [DbContext(typeof(EventDbContext))]
    partial class EventDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("AngularDotnetDemo.Core.Entities.Event", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Ein fröhliches Sommerfest mit Livemusik, Essen und Spielen für die ganze Familie.",
                            ImagePath = "/images/events/sommerfest2024.jpg",
                            Location = "Stadtpark, Hamburg",
                            Name = "Sommerfest 2024"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "Die größte Tech-Konferenz in Europa mit Vorträgen von führenden Branchenexperten.",
                            ImagePath = "/images/events/tech-konferenz2024.jpg",
                            Location = "Messegelände, Berlin",
                            Name = "Tech-Konferenz 2024"
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Erleben Sie die Werke internationaler Künstler und genießen Sie kulturelle Darbietungen.",
                            ImagePath = "/images/events/kunst-kultur-festival.jpg",
                            Location = "Altstadt, München",
                            Name = "Kunst und Kultur Festival"
                        },
                        new
                        {
                            Id = 4L,
                            Description = "Ein zauberhafter Weihnachtsmarkt mit Glühwein, Handwerkskunst und einer Eislaufbahn.",
                            ImagePath = "/images/events/winterwunderland-markt.jpg",
                            Location = "Schlossplatz, Dresden",
                            Name = "Winterwunderland Markt"
                        },
                        new
                        {
                            Id = 5L,
                            Description = "Ein exklusives Jazz-Konzert mit bekannten internationalen Musikern.",
                            ImagePath = "/images/events/jazz-nacht2024.jpg",
                            Location = "Konzerthaus, Frankfurt",
                            Name = "Jazz Nacht 2024"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
