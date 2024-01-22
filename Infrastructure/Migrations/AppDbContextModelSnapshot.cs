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
                            Id = new Guid("5599b8eb-7db2-4146-a975-e1f2a211b76c"),
                            Address = "Kungsgatan 123, Göteborg",
                            DateOfBirth = new DateOnly(2006, 5, 12),
                            Email = "elsa.andersson@schoolsync.com",
                            FirstName = "Elsa",
                            LastName = "Andersson",
                            PhoneNumber = "+46 70 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("6f2591e8-ced3-4a9e-9e73-63077de1d428"),
                            Address = "Avenyn 456, Göteborg",
                            DateOfBirth = new DateOnly(2005, 8, 21),
                            Email = "oscar.bergqvist@schoolsync.com",
                            FirstName = "Oscar",
                            LastName = "Bergqvist",
                            PhoneNumber = "+46 72 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("6fe55b1c-e348-4a44-8948-fba52c6e87a4"),
                            Address = "Vasagatan 789, Göteborg",
                            DateOfBirth = new DateOnly(2007, 11, 3),
                            Email = "hanna.carlsson@schoolsync.com",
                            FirstName = "Hanna",
                            LastName = "Carlsson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("2f4f6148-d43f-4319-ac1f-39a3599d0c14"),
                            Address = "Haga Nygata 101, Göteborg",
                            DateOfBirth = new DateOnly(2007, 2, 15),
                            Email = "alexander.dahlstrom@schoolsync.com",
                            FirstName = "Alexander",
                            LastName = "Dahlström",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("0429a046-e220-4a14-860f-6cd2dc4ecf91"),
                            Address = "Linnégatan 202, Göteborg",
                            DateOfBirth = new DateOnly(2006, 4, 28),
                            Email = "emma.ekstrom@schoolsync.com",
                            FirstName = "Emma",
                            LastName = "Ekström",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("c5eae628-b53c-4ceb-aaa1-90f85ef8a039"),
                            Address = "Kungsportsavenyn 303, Göteborg",
                            DateOfBirth = new DateOnly(2005, 7, 8),
                            Email = "liam.forsberg@schoolsync.com",
                            FirstName = "Liam",
                            LastName = "Forsberg",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("a544aff0-7b33-406e-b90d-115e027bb1a1"),
                            Address = "Första Långgatan 404, Göteborg",
                            DateOfBirth = new DateOnly(2007, 10, 19),
                            Email = "ella.gustavsson@schoolsync.com",
                            FirstName = "Ella",
                            LastName = "Gustavsson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("cfd66e76-c727-43c8-a6d9-5f363378ba83"),
                            Address = "Andra Långgatan 505, Göteborg",
                            DateOfBirth = new DateOnly(2005, 1, 31),
                            Email = "oliver.hedlund@schoolsync.com",
                            FirstName = "Oliver",
                            LastName = "Hedlund",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("a21d0e20-a426-42cb-9008-bc02cd2406ad"),
                            Address = "Västra Hamngatan 606, Göteborg",
                            DateOfBirth = new DateOnly(2006, 3, 14),
                            Email = "maja.isaksson@schoolsync.com",
                            FirstName = "Maja",
                            LastName = "Isaksson",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("8b214e7b-c043-42f1-80a2-6f699ad84338"),
                            Address = "Storgatan 707, Göteborg",
                            DateOfBirth = new DateOnly(2005, 6, 25),
                            Email = "william.johansson@schoolsync.com",
                            FirstName = "William",
                            LastName = "Johansson",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("d43c6516-8e47-4385-881e-bf0cc1b4c115"),
                            Address = "Östra Hamngatan 808, Göteborg",
                            DateOfBirth = new DateOnly(2007, 9, 5),
                            Email = "alice.karlsson@schoolsync.com",
                            FirstName = "Alice",
                            LastName = "Karlsson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("7394f9e1-cf4f-42ee-bd13-1784d633d048"),
                            Address = "Nordenskiöldsgatan 909, Göteborg",
                            DateOfBirth = new DateOnly(2005, 12, 16),
                            Email = "noah.lindgren@schoolsync.com",
                            FirstName = "Noah",
                            LastName = "Lindgren",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("09e2e69f-8ac0-4341-a7ae-848637c19e9a"),
                            Address = "Lisebergsgatan 1111, Göteborg",
                            DateOfBirth = new DateOnly(2006, 2, 27),
                            Email = "astrid.svensson@schoolsync.com",
                            FirstName = "Astrid",
                            LastName = "Svensson",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("7940e5d9-abca-4633-8897-ec8e5149bb7c"),
                            Address = "Fiskebäcksgatan 1212, Göteborg",
                            DateOfBirth = new DateOnly(2005, 5, 9),
                            Email = "erik.toresson@schoolsync.com",
                            FirstName = "Erik",
                            LastName = "Toresson",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("18ede236-2a88-45c1-ae4c-8e098b5428b6"),
                            Address = "Karl Johansgatan 1313, Göteborg",
                            DateOfBirth = new DateOnly(2007, 8, 20),
                            Email = "amanda.vikstrom@schoolsync.com",
                            FirstName = "Amanda",
                            LastName = "Vikström",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("67671e6a-c482-4139-a0a7-5599c2128c8c"),
                            Address = "Magasinsgatan 1414, Göteborg",
                            DateOfBirth = new DateOnly(2006, 11, 1),
                            Email = "gustav.werner@schoolsync.com",
                            FirstName = "Gustav",
                            LastName = "Werner",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("bcda90ba-a22a-43d7-9a56-0eaf783a687b"),
                            Address = "Södra Hamngatan 1515, Göteborg",
                            DateOfBirth = new DateOnly(2005, 1, 15),
                            Email = "sofia.aberg@schoolsync.com",
                            FirstName = "Sofia",
                            LastName = "Åberg",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("df57d14f-971c-411a-b886-40a7ff2cdb93"),
                            Address = "Götgatan 1616, Göteborg",
                            DateOfBirth = new DateOnly(2007, 4, 28),
                            Email = "filip.oberg@schoolsync.com",
                            FirstName = "Filip",
                            LastName = "Öberg",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("1c84df29-265f-4ef4-9a62-3236e9e81edb"),
                            Address = "Ekelundsgatan 1717, Göteborg",
                            DateOfBirth = new DateOnly(2005, 7, 8),
                            Email = "viktoria.pettersson@schoolsync.com",
                            FirstName = "Viktoria",
                            LastName = "Pettersson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("c7b22823-caf4-4dcc-842c-3a0957e39adb"),
                            Address = "Färjenäsgatan 1818, Göteborg",
                            DateOfBirth = new DateOnly(2006, 10, 19),
                            Email = "axel.sjoberg@schoolsync.com",
                            FirstName = "Axel",
                            LastName = "Sjöberg",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("78048440-4a12-4aa2-9e98-b304df5a017a"),
                            Address = "Trädgårdsgatan 1919, Göteborg",
                            DateOfBirth = new DateOnly(2005, 12, 31),
                            Email = "isabelle.holm@schoolsync.com",
                            FirstName = "Isabelle",
                            LastName = "Holm",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("f2fe8402-f7e3-4355-8977-1fe19394e1de"),
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
                            Id = new Guid("89317b64-fb8c-48fd-81fb-871d4970550b"),
                            Address = "Skolgatan 1, Göteborg",
                            DateOfBirth = new DateOnly(1980, 6, 15),
                            Email = "karin.lind@schoolsync.com",
                            FirstName = "Karin",
                            LastName = "Lind",
                            PhoneNumber = "+46 70 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("e00792b2-ea43-463f-876f-881037b37a81"),
                            Address = "Lärargatan 2, Göteborg",
                            DateOfBirth = new DateOnly(1975, 9, 21),
                            Email = "anders.svensson@schoolsync.com",
                            FirstName = "Anders",
                            LastName = "Svensson",
                            PhoneNumber = "+46 72 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("0b848ce3-8797-4555-ae8e-af12a0ba6194"),
                            Address = "Undervisningsvägen 3, Göteborg",
                            DateOfBirth = new DateOnly(1982, 11, 3),
                            Email = "camilla.eriksson@schoolsync.com",
                            FirstName = "Camilla",
                            LastName = "Eriksson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("2b15389e-c176-4349-b74b-4503084619c0"),
                            Address = "Lärarvägen 4, Göteborg",
                            DateOfBirth = new DateOnly(1978, 2, 15),
                            Email = "mats.andersson@schoolsync.com",
                            FirstName = "Mats",
                            LastName = "Andersson",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("c30d0564-0bb4-42ef-b3e6-3b6e4af1c5cc"),
                            Address = "Pedagogvägen 5, Göteborg",
                            DateOfBirth = new DateOnly(1985, 4, 28),
                            Email = "anna.hedstrom@schoolsync.com",
                            FirstName = "Anna",
                            LastName = "Hedström",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("0980bf71-d31a-49fc-bb2b-7b61b118b283"),
                            Address = "Lärarstråket 6, Göteborg",
                            DateOfBirth = new DateOnly(1973, 7, 8),
                            Email = "erik.berg@schoolsync.com",
                            FirstName = "Erik",
                            LastName = "Berg",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("1bdc9d77-75fd-4f73-ad3d-0a6e18f752b9"),
                            Address = "Utvecklingsgatan 7, Göteborg",
                            DateOfBirth = new DateOnly(1987, 10, 19),
                            Email = "sara.johansson@schoolsync.com",
                            FirstName = "Sara",
                            LastName = "Johansson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("f344552e-3fa5-4a90-ace3-181a68872092"),
                            Address = "Lärarvägen 8, Göteborg",
                            DateOfBirth = new DateOnly(1979, 1, 31),
                            Email = "johan.lund@schoolsync.com",
                            FirstName = "Johan",
                            LastName = "Lund",
                            PhoneNumber = "+46 76 789 01 23"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
