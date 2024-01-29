﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Models.Student.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = new Guid("909209aa-bc1a-4c18-8738-aae4d93fd55d"),
                            Address = "Kungsgatan 123, Göteborg",
                            DateOfBirth = new DateOnly(2006, 5, 12),
                            Email = "elsa.andersson@schoolsync.com",
                            FirstName = "Elsa",
                            LastName = "Andersson",
                            PhoneNumber = "+46 70 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("65c467f4-c12a-4c01-b31a-b48ba32cd07d"),
                            Address = "Avenyn 456, Göteborg",
                            DateOfBirth = new DateOnly(2005, 8, 21),
                            Email = "oscar.bergqvist@schoolsync.com",
                            FirstName = "Oscar",
                            LastName = "Bergqvist",
                            PhoneNumber = "+46 72 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("4174efe4-55ca-4b8a-80fe-f8126f1f81d8"),
                            Address = "Vasagatan 789, Göteborg",
                            DateOfBirth = new DateOnly(2007, 11, 3),
                            Email = "hanna.carlsson@schoolsync.com",
                            FirstName = "Hanna",
                            LastName = "Carlsson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("220a3b99-61ea-46c9-afc9-f2b07d2bbd60"),
                            Address = "Haga Nygata 101, Göteborg",
                            DateOfBirth = new DateOnly(2007, 2, 15),
                            Email = "alexander.dahlstrom@schoolsync.com",
                            FirstName = "Alexander",
                            LastName = "Dahlström",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("0700e46c-acd4-4343-a8ad-dd8f8f5bd7c8"),
                            Address = "Linnégatan 202, Göteborg",
                            DateOfBirth = new DateOnly(2006, 4, 28),
                            Email = "emma.ekstrom@schoolsync.com",
                            FirstName = "Emma",
                            LastName = "Ekström",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("ed83bf39-5171-4d8b-b4e6-25df108df389"),
                            Address = "Kungsportsavenyn 303, Göteborg",
                            DateOfBirth = new DateOnly(2005, 7, 8),
                            Email = "liam.forsberg@schoolsync.com",
                            FirstName = "Liam",
                            LastName = "Forsberg",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("06599a85-0ed3-44e8-b7fc-c866d961d4f6"),
                            Address = "Första Långgatan 404, Göteborg",
                            DateOfBirth = new DateOnly(2007, 10, 19),
                            Email = "ella.gustavsson@schoolsync.com",
                            FirstName = "Ella",
                            LastName = "Gustavsson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("74297502-120f-4103-960c-7c3b015b0565"),
                            Address = "Andra Långgatan 505, Göteborg",
                            DateOfBirth = new DateOnly(2005, 1, 31),
                            Email = "oliver.hedlund@schoolsync.com",
                            FirstName = "Oliver",
                            LastName = "Hedlund",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("03a36ad4-1352-4bfb-abca-ab1bfe1a2980"),
                            Address = "Västra Hamngatan 606, Göteborg",
                            DateOfBirth = new DateOnly(2006, 3, 14),
                            Email = "maja.isaksson@schoolsync.com",
                            FirstName = "Maja",
                            LastName = "Isaksson",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("1b17fb34-6a73-41a0-a4df-24fedae6762e"),
                            Address = "Storgatan 707, Göteborg",
                            DateOfBirth = new DateOnly(2005, 6, 25),
                            Email = "william.johansson@schoolsync.com",
                            FirstName = "William",
                            LastName = "Johansson",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("8612c821-e2b9-4ac8-a14c-58cb26d85970"),
                            Address = "Östra Hamngatan 808, Göteborg",
                            DateOfBirth = new DateOnly(2007, 9, 5),
                            Email = "alice.karlsson@schoolsync.com",
                            FirstName = "Alice",
                            LastName = "Karlsson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("3e992767-9dc5-4a6c-a399-9fe89788cc2e"),
                            Address = "Nordenskiöldsgatan 909, Göteborg",
                            DateOfBirth = new DateOnly(2005, 12, 16),
                            Email = "noah.lindgren@schoolsync.com",
                            FirstName = "Noah",
                            LastName = "Lindgren",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("cd386386-4b45-4eac-9f9b-0cfa343a5ce2"),
                            Address = "Lisebergsgatan 1111, Göteborg",
                            DateOfBirth = new DateOnly(2006, 2, 27),
                            Email = "astrid.svensson@schoolsync.com",
                            FirstName = "Astrid",
                            LastName = "Svensson",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("363e18f2-a2d6-42c4-85a9-7f135fd109db"),
                            Address = "Fiskebäcksgatan 1212, Göteborg",
                            DateOfBirth = new DateOnly(2005, 5, 9),
                            Email = "erik.toresson@schoolsync.com",
                            FirstName = "Erik",
                            LastName = "Toresson",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("2384aa34-b746-4edc-8f64-cf8fdb831b40"),
                            Address = "Karl Johansgatan 1313, Göteborg",
                            DateOfBirth = new DateOnly(2007, 8, 20),
                            Email = "amanda.vikstrom@schoolsync.com",
                            FirstName = "Amanda",
                            LastName = "Vikström",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("82f2eba8-4572-4100-8e95-951a760ef98c"),
                            Address = "Magasinsgatan 1414, Göteborg",
                            DateOfBirth = new DateOnly(2006, 11, 1),
                            Email = "gustav.werner@schoolsync.com",
                            FirstName = "Gustav",
                            LastName = "Werner",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("1e137ebd-9529-405e-bc08-6f02a418c202"),
                            Address = "Södra Hamngatan 1515, Göteborg",
                            DateOfBirth = new DateOnly(2005, 1, 15),
                            Email = "sofia.aberg@schoolsync.com",
                            FirstName = "Sofia",
                            LastName = "Åberg",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("39f6efdf-a261-4ed7-a78c-28e12b4aa94a"),
                            Address = "Götgatan 1616, Göteborg",
                            DateOfBirth = new DateOnly(2007, 4, 28),
                            Email = "filip.oberg@schoolsync.com",
                            FirstName = "Filip",
                            LastName = "Öberg",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("20ae656d-b4e4-41e3-b2ce-236f69850e15"),
                            Address = "Ekelundsgatan 1717, Göteborg",
                            DateOfBirth = new DateOnly(2005, 7, 8),
                            Email = "viktoria.pettersson@schoolsync.com",
                            FirstName = "Viktoria",
                            LastName = "Pettersson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("48ba268f-aee2-4a33-846f-e612d81e80c9"),
                            Address = "Färjenäsgatan 1818, Göteborg",
                            DateOfBirth = new DateOnly(2006, 10, 19),
                            Email = "axel.sjoberg@schoolsync.com",
                            FirstName = "Axel",
                            LastName = "Sjöberg",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("64236fd1-cc43-407e-9d66-4dbcef85da1a"),
                            Address = "Trädgårdsgatan 1919, Göteborg",
                            DateOfBirth = new DateOnly(2005, 12, 31),
                            Email = "isabelle.holm@schoolsync.com",
                            FirstName = "Isabelle",
                            LastName = "Holm",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("302ee074-7951-48b7-80a4-416cd7245c61"),
                            Address = "Mölndalsvägen 2020, Göteborg",
                            DateOfBirth = new DateOnly(2007, 2, 14),
                            Email = "marcus.lundqvist@schoolsync.com",
                            FirstName = "Marcus",
                            LastName = "Lundqvist",
                            PhoneNumber = "+46 70 345 67 89"
                        });
                });

            modelBuilder.Entity("Domain.Models.Teacher.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Teacher");

                    b.HasData(
                        new
                        {
                            Id = new Guid("576196c8-b02e-4fb0-9aea-8949cb5d71f7"),
                            Address = "Skolgatan 1, Göteborg",
                            DateOfBirth = new DateOnly(1980, 6, 15),
                            Email = "karin.lind@schoolsync.com",
                            FirstName = "Karin",
                            LastName = "Lind",
                            PhoneNumber = "+46 70 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("2ee39394-e18d-401f-a9cb-8f92eb309d2a"),
                            Address = "Lärargatan 2, Göteborg",
                            DateOfBirth = new DateOnly(1975, 9, 21),
                            Email = "anders.svensson@schoolsync.com",
                            FirstName = "Anders",
                            LastName = "Svensson",
                            PhoneNumber = "+46 72 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("5229b77e-875d-4342-ad6c-f2760426d335"),
                            Address = "Undervisningsvägen 3, Göteborg",
                            DateOfBirth = new DateOnly(1982, 11, 3),
                            Email = "camilla.eriksson@schoolsync.com",
                            FirstName = "Camilla",
                            LastName = "Eriksson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("3039c421-2a90-450d-bc48-f6e5056fa9ab"),
                            Address = "Lärarvägen 4, Göteborg",
                            DateOfBirth = new DateOnly(1978, 2, 15),
                            Email = "mats.andersson@schoolsync.com",
                            FirstName = "Mats",
                            LastName = "Andersson",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("b3e7d71a-070a-45e9-aed7-c50c8cca3e2e"),
                            Address = "Pedagogvägen 5, Göteborg",
                            DateOfBirth = new DateOnly(1985, 4, 28),
                            Email = "anna.hedstrom@schoolsync.com",
                            FirstName = "Anna",
                            LastName = "Hedström",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("4243e386-53a3-45d7-b8b3-9900cd6966e5"),
                            Address = "Lärarstråket 6, Göteborg",
                            DateOfBirth = new DateOnly(1973, 7, 8),
                            Email = "erik.berg@schoolsync.com",
                            FirstName = "Erik",
                            LastName = "Berg",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("43382108-73a8-4169-8ff1-55bc990e337f"),
                            Address = "Utvecklingsgatan 7, Göteborg",
                            DateOfBirth = new DateOnly(1987, 10, 19),
                            Email = "sara.johansson@schoolsync.com",
                            FirstName = "Sara",
                            LastName = "Johansson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("fd1670ae-888a-4aa0-9504-76be0f3b988f"),
                            Address = "Lärarvägen 8, Göteborg",
                            DateOfBirth = new DateOnly(1979, 1, 31),
                            Email = "johan.lund@schoolsync.com",
                            FirstName = "Johan",
                            LastName = "Lund",
                            PhoneNumber = "+46 76 789 01 23"
                        });
                });

            modelBuilder.Entity("Domain.Models.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
