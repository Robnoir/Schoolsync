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
                            Id = new Guid("cc8e85aa-5cd1-41bb-acd6-6540b7920297"),
                            Adress = "Kungsgatan 123, Göteborg",
                            DateOfBirth = new DateOnly(2006, 5, 12),
                            Email = "elsa.andersson@schoolsync.com",
                            FirstName = "Elsa",
                            LastName = "Andersson",
                            PhoneNumber = "+46 70 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("0eea8fe8-3eca-415b-97b1-3d90aaa75abf"),
                            Adress = "Avenyn 456, Göteborg",
                            DateOfBirth = new DateOnly(2005, 8, 21),
                            Email = "oscar.bergqvist@schoolsync.com",
                            FirstName = "Oscar",
                            LastName = "Bergqvist",
                            PhoneNumber = "+46 72 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("ba109366-4630-47e0-afc7-b7b8ecdae08c"),
                            Adress = "Vasagatan 789, Göteborg",
                            DateOfBirth = new DateOnly(2007, 11, 3),
                            Email = "hanna.carlsson@schoolsync.com",
                            FirstName = "Hanna",
                            LastName = "Carlsson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("42d72f1c-b1be-4773-99de-160a43918d93"),
                            Adress = "Haga Nygata 101, Göteborg",
                            DateOfBirth = new DateOnly(2007, 2, 15),
                            Email = "alexander.dahlstrom@schoolsync.com",
                            FirstName = "Alexander",
                            LastName = "Dahlström",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("a02b5c55-e1d0-482e-8034-34810d0e4782"),
                            Adress = "Linnégatan 202, Göteborg",
                            DateOfBirth = new DateOnly(2006, 4, 28),
                            Email = "emma.ekstrom@schoolsync.com",
                            FirstName = "Emma",
                            LastName = "Ekström",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("e46b745a-d292-4de0-b171-a99fec202f70"),
                            Adress = "Kungsportsavenyn 303, Göteborg",
                            DateOfBirth = new DateOnly(2005, 7, 8),
                            Email = "liam.forsberg@schoolsync.com",
                            FirstName = "Liam",
                            LastName = "Forsberg",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("d108e62b-0f15-4228-9b1b-b082a13e97b9"),
                            Adress = "Första Långgatan 404, Göteborg",
                            DateOfBirth = new DateOnly(2007, 10, 19),
                            Email = "ella.gustavsson@schoolsync.com",
                            FirstName = "Ella",
                            LastName = "Gustavsson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("e3b185ae-02c2-479c-a557-9982761c7be8"),
                            Adress = "Andra Långgatan 505, Göteborg",
                            DateOfBirth = new DateOnly(2005, 1, 31),
                            Email = "oliver.hedlund@schoolsync.com",
                            FirstName = "Oliver",
                            LastName = "Hedlund",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("563b2b3d-908d-46a6-b8ab-ab8a01697560"),
                            Adress = "Västra Hamngatan 606, Göteborg",
                            DateOfBirth = new DateOnly(2006, 3, 14),
                            Email = "maja.isaksson@schoolsync.com",
                            FirstName = "Maja",
                            LastName = "Isaksson",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("5abb712b-18ff-4e22-a4f7-efc1015ed4ea"),
                            Adress = "Storgatan 707, Göteborg",
                            DateOfBirth = new DateOnly(2005, 6, 25),
                            Email = "william.johansson@schoolsync.com",
                            FirstName = "William",
                            LastName = "Johansson",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("82f4b83a-07b0-479b-ba3b-2e2eb6573022"),
                            Adress = "Östra Hamngatan 808, Göteborg",
                            DateOfBirth = new DateOnly(2007, 9, 5),
                            Email = "alice.karlsson@schoolsync.com",
                            FirstName = "Alice",
                            LastName = "Karlsson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("d6a77abb-9860-4eab-a2c9-7bb67db3148e"),
                            Adress = "Nordenskiöldsgatan 909, Göteborg",
                            DateOfBirth = new DateOnly(2005, 12, 16),
                            Email = "noah.lindgren@schoolsync.com",
                            FirstName = "Noah",
                            LastName = "Lindgren",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("d274a649-30af-4ec0-9322-ae9d57b68340"),
                            Adress = "Lisebergsgatan 1111, Göteborg",
                            DateOfBirth = new DateOnly(2006, 2, 27),
                            Email = "astrid.svensson@schoolsync.com",
                            FirstName = "Astrid",
                            LastName = "Svensson",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("c9366e0f-91b2-4267-b89d-81c626fd2b6b"),
                            Adress = "Fiskebäcksgatan 1212, Göteborg",
                            DateOfBirth = new DateOnly(2005, 5, 9),
                            Email = "erik.toresson@schoolsync.com",
                            FirstName = "Erik",
                            LastName = "Toresson",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("618c8c20-86f2-4479-a550-b540dcfaa1e9"),
                            Adress = "Karl Johansgatan 1313, Göteborg",
                            DateOfBirth = new DateOnly(2007, 8, 20),
                            Email = "amanda.vikstrom@schoolsync.com",
                            FirstName = "Amanda",
                            LastName = "Vikström",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("4045699c-da31-432e-b0f2-7a4630409048"),
                            Adress = "Magasinsgatan 1414, Göteborg",
                            DateOfBirth = new DateOnly(2006, 11, 1),
                            Email = "gustav.werner@schoolsync.com",
                            FirstName = "Gustav",
                            LastName = "Werner",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("4104c0d9-9ebf-48a0-853a-9898061f18c0"),
                            Adress = "Södra Hamngatan 1515, Göteborg",
                            DateOfBirth = new DateOnly(2005, 1, 15),
                            Email = "sofia.aberg@schoolsync.com",
                            FirstName = "Sofia",
                            LastName = "Åberg",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("839277e5-ffcc-4ccc-9ae9-187b4394a438"),
                            Adress = "Götgatan 1616, Göteborg",
                            DateOfBirth = new DateOnly(2007, 4, 28),
                            Email = "filip.oberg@schoolsync.com",
                            FirstName = "Filip",
                            LastName = "Öberg",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("78dcb205-e5b3-4c79-bf8d-467a1d6ee312"),
                            Adress = "Ekelundsgatan 1717, Göteborg",
                            DateOfBirth = new DateOnly(2005, 7, 8),
                            Email = "viktoria.pettersson@schoolsync.com",
                            FirstName = "Viktoria",
                            LastName = "Pettersson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("1db948fa-70cb-4604-aa29-01a79555b4b8"),
                            Adress = "Färjenäsgatan 1818, Göteborg",
                            DateOfBirth = new DateOnly(2006, 10, 19),
                            Email = "axel.sjoberg@schoolsync.com",
                            FirstName = "Axel",
                            LastName = "Sjöberg",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("f40ac66c-caad-43b5-a0ef-155d3dd6077f"),
                            Adress = "Trädgårdsgatan 1919, Göteborg",
                            DateOfBirth = new DateOnly(2005, 12, 31),
                            Email = "isabelle.holm@schoolsync.com",
                            FirstName = "Isabelle",
                            LastName = "Holm",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("c140e092-15a4-4a51-b06d-9c9064751118"),
                            Adress = "Mölndalsvägen 2020, Göteborg",
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
                            Id = new Guid("38648c1a-4b93-435c-9d93-d08c347e69e9"),
                            Adress = "Skolgatan 1, Göteborg",
                            DateOfBirth = new DateOnly(1980, 6, 15),
                            Email = "karin.lind@schoolsync.com",
                            FirstName = "Karin",
                            LastName = "Lind",
                            PhoneNumber = "+46 70 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("3ab7cd74-7e03-408a-8187-ebfcbb24f8f3"),
                            Adress = "Lärargatan 2, Göteborg",
                            DateOfBirth = new DateOnly(1975, 9, 21),
                            Email = "anders.svensson@schoolsync.com",
                            FirstName = "Anders",
                            LastName = "Svensson",
                            PhoneNumber = "+46 72 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("af259c3d-4527-4382-a888-03eb38d114af"),
                            Adress = "Undervisningsvägen 3, Göteborg",
                            DateOfBirth = new DateOnly(1982, 11, 3),
                            Email = "camilla.eriksson@schoolsync.com",
                            FirstName = "Camilla",
                            LastName = "Eriksson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("d990d5ea-5c9b-4efa-bc37-311eb9de4af8"),
                            Adress = "Lärarvägen 4, Göteborg",
                            DateOfBirth = new DateOnly(1978, 2, 15),
                            Email = "mats.andersson@schoolsync.com",
                            FirstName = "Mats",
                            LastName = "Andersson",
                            PhoneNumber = "+46 76 789 01 23"
                        },
                        new
                        {
                            Id = new Guid("67c77b82-ed33-406d-8fad-cd05195548c8"),
                            Adress = "Pedagogvägen 5, Göteborg",
                            DateOfBirth = new DateOnly(1985, 4, 28),
                            Email = "anna.hedstrom@schoolsync.com",
                            FirstName = "Anna",
                            LastName = "Hedström",
                            PhoneNumber = "+46 72 123 45 67"
                        },
                        new
                        {
                            Id = new Guid("862abebe-db3d-4323-8c35-af794e8ee05f"),
                            Adress = "Lärarstråket 6, Göteborg",
                            DateOfBirth = new DateOnly(1973, 7, 8),
                            Email = "erik.berg@schoolsync.com",
                            FirstName = "Erik",
                            LastName = "Berg",
                            PhoneNumber = "+46 70 345 67 89"
                        },
                        new
                        {
                            Id = new Guid("875cf839-4c6a-44db-b7f6-d5eb014e09b0"),
                            Adress = "Utvecklingsgatan 7, Göteborg",
                            DateOfBirth = new DateOnly(1987, 10, 19),
                            Email = "sara.johansson@schoolsync.com",
                            FirstName = "Sara",
                            LastName = "Johansson",
                            PhoneNumber = "+46 73 567 89 01"
                        },
                        new
                        {
                            Id = new Guid("002f7674-874f-490d-85aa-6db99c9223ac"),
                            Adress = "Lärarvägen 8, Göteborg",
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
