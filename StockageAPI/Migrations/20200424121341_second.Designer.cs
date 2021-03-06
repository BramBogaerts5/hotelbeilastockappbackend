﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockageAPI.Context;

namespace StockageAPI.Migrations
{
    [DbContext(typeof(StockageContext))]
    [Migration("20200424121341_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockageAPI.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Sauvignon Friuli",
                            Soort = "Wit",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 2,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Bordeaux Sirius White",
                            Soort = "Wit",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 3,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Soltema",
                            Soort = "Rood",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 4,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Bordeaux Sirius Red",
                            Soort = "Rood",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 5,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Poesia",
                            Soort = "Rose",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 6,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Bordeaux Sirius Rosé",
                            Soort = "Rose",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 7,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Côtes de Gascogne Chardonnay",
                            Soort = "Wit",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 8,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Recorbian Soave",
                            Soort = "Wit",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 9,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Pinot Grigio",
                            Soort = "Wit",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 10,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Rueda Menade",
                            Soort = "Wit",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 11,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Côtes du Rhone Parallele 45",
                            Soort = "Wit",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 12,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Nuricante",
                            Soort = "Wit",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 13,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Fiano di Avellino",
                            Soort = "Wit",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 14,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Stellenbosch Ken Forrester",
                            Soort = "Wit",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 15,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Roero Arneis La Brina",
                            Soort = "Wit",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 16,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Ligeja Vermentino di Sardegna",
                            Soort = "Wit",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 17,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Bekaa de Marsyas Wit",
                            Soort = "Wit",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 18,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Pouilly-Fumé La Moynerie",
                            Soort = "Wit",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 19,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Chablis Saint Martin",
                            Soort = "Wit",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 20,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Stoan Bianco",
                            Soort = "Wit",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 21,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Chassagne Montrachet",
                            Soort = "Wit",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 22,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Cahors Le Pur Fruit du Causse",
                            Soort = "Rood",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 23,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Ronco dei Quatroventi",
                            Soort = "Rood",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 24,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Jumilla Monastrell",
                            Soort = "Rood",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 25,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Barbera d'Alba Canova Superiore",
                            Soort = "Rood",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 26,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Bekaa de Marsyas Rood",
                            Soort = "Rood",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 27,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Rioja Gabaxo",
                            Soort = "Rood",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 28,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Taurasi",
                            Soort = "Rood",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 29,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Rully La Chaume",
                            Soort = "Rood",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 30,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Saint Emilion Grand Cru",
                            Soort = "Rood",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 31,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Meone",
                            Soort = "Rood",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 32,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Brunello di Montalcino",
                            Soort = "Rood",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 33,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Chateauneuf de Pape",
                            Soort = "Rood",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 34,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Amarone",
                            Soort = "Rood",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 35,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Barolo Galina",
                            Soort = "Rood",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 36,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "T Cuvee Rosé",
                            Soort = "Rose",
                            Supplier = "Olio Vino"
                        },
                        new
                        {
                            ProductId = 37,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "AIX normale fles",
                            Soort = "Rose",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 38,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "AIX magnumfles",
                            Soort = "Rose",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 39,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Prosecco Brut",
                            Soort = "Bubbels",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 40,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Prosecco Rosé",
                            Soort = "Bubbels",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 41,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Champagne Cuvee de Reserve",
                            Soort = "Bubbels",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 42,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Champagne Grande Reserve Chardonnay",
                            Soort = "Bubbels",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 43,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Champagne Rosé",
                            Soort = "Bubbels",
                            Supplier = "ViniFera"
                        },
                        new
                        {
                            ProductId = 44,
                            Amount = 1,
                            Area = "Bar",
                            Description = "Per fles",
                            Name = "Champagne Cuvee Carbon",
                            Soort = "Bubbels",
                            Supplier = "ViniFera"
                        });
                });

            modelBuilder.Entity("StockageAPI.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Name = "Bram",
                            Password = "Test123"
                        },
                        new
                        {
                            UserId = 2,
                            Name = "Karlo",
                            Password = "Test123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
