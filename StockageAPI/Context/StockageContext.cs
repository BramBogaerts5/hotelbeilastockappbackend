using Microsoft.EntityFrameworkCore;
using StockageAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockageAPI.Context
{
    public class StockageContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public StockageContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.UserId)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<Product>()
                .Property(p => p.ProductId)
                .HasColumnName("Id")
                .IsRequired();

            SeedUsersTable(modelBuilder);
            SeedProductsTable(modelBuilder);
        }

        private void SeedUsersTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new List<User>
            {
                new User
                {
                    UserId = 1,
                    Name = "Bram",
                    Password = "Test123"
                },
                new User
                {
                    UserId = 2,
                    Name = "Karlo",
                    Password = "Test123"
                }
            });
        }

        private void SeedProductsTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Sauvignon Friuli",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 2,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Bordeaux Sirius White",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 3,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Soltema",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 4,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Bordeaux Sirius Red",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 5,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rose",
                    Description = "Per fles",
                    Name = "Poesia",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 6,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rose",
                    Description = "Per fles",
                    Name = "Bordeaux Sirius Rosé",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 7,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Côtes de Gascogne Chardonnay",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 8,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Recorbian Soave",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 9,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Pinot Grigio",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 10,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Rueda Menade",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 11,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Côtes du Rhone Parallele 45",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 12,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Nuricante",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 13,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Fiano di Avellino",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 14,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Stellenbosch Ken Forrester",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 15,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Roero Arneis La Brina",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 16,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Ligeja Vermentino di Sardegna",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 17,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Bekaa de Marsyas Wit",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 18,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Pouilly-Fumé La Moynerie",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 19,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Chablis Saint Martin",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 20,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Stoan Bianco",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 21,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Wit",
                    Description = "Per fles",
                    Name = "Chassagne Montrachet",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 22,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Cahors Le Pur Fruit du Causse",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 23,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Ronco dei Quatroventi",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 24,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Jumilla Monastrell",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 25,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Barbera d'Alba Canova Superiore",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 26,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Bekaa de Marsyas Rood",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 27,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Rioja Gabaxo",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 28,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Taurasi",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 29,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Rully La Chaume",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 30,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Saint Emilion Grand Cru",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 31,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Meone",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 32,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Brunello di Montalcino",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 33,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Chateauneuf de Pape",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 34,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Amarone",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 35,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rood",
                    Description = "Per fles",
                    Name = "Barolo Galina",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 36,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rose",
                    Description = "Per fles",
                    Name = "T Cuvee Rosé",
                    Supplier = "Olio Vino"
                },
                new Product
                {
                    ProductId = 37,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rose",
                    Description = "Per fles",
                    Name = "AIX normale fles",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 38,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Rose",
                    Description = "Per fles",
                    Name = "AIX magnumfles",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 39,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Bubbels",
                    Description = "Per fles",
                    Name = "Prosecco Brut",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 40,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Bubbels",
                    Description = "Per fles",
                    Name = "Prosecco Rosé",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 41,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Bubbels",
                    Description = "Per fles",
                    Name = "Champagne Cuvee de Reserve",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 42,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Bubbels",
                    Description = "Per fles",
                    Name = "Champagne Grande Reserve Chardonnay",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 43,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Bubbels",
                    Description = "Per fles",
                    Name = "Champagne Rosé",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 44,
                    Amount = 1,
                    Area = "Bar",
                    Soort = "Bubbels",
                    Description = "Per fles",
                    Name = "Champagne Cuvee Carbon",
                    Supplier = "ViniFera"
                },
                new Product
                {
                    ProductId = 45,
                    Amount = 1,
                    Area = "Breakfast",
                    Soort = "Food",
                    Description = "Per pak",
                    Name = "Eieren",
                    Supplier = "Van Zon"
                },
                new Product
                {
                    ProductId = 46,
                    Amount = 1,
                    Area = "Breakfast",
                    Soort = "Food",
                    Description = "Per pak",
                    Name = "Spek",
                    Supplier = "Van Zon"
                },
                new Product
                {
                    ProductId = 47,
                    Amount = 1,
                    Area = "Breakfast",
                    Soort = "Food",
                    Description = "Per pak",
                    Name = "Jonge Kaas",
                    Supplier = "Van Zon"
                },
                new Product
                {
                    ProductId = 48,
                    Amount = 1,
                    Area = "Breakfast",
                    Soort = "Drinks",
                    Description = "Per pak",
                    Name = "Varesa Fruitsap",
                    Supplier = "Van Zon"
                },
                new Product
                {
                    ProductId = 49,
                    Amount = 1,
                    Area = "Breakfast",
                    Soort = "Food",
                    Description = "Per pak",
                    Name = "Zalm",
                    Supplier = "Van Zon"
                },
                new Product
                {
                    ProductId = 50,
                    Amount = 1,
                    Area = "Breakfast",
                    Soort = "Food",
                    Description = "Per pak",
                    Name = "Brie",
                    Supplier = "Van Zon"
                },
                new Product
                {
                    ProductId = 51,
                    Amount = 1,
                    Area = "Breakfast",
                    Soort = "Fruit",
                    Description = "Per unit",
                    Name = "Appels",
                    Supplier = "De Haspengouwer"
                },
                new Product
                {
                    ProductId = 52,
                    Amount = 1,
                    Area = "Breakfast",
                    Soort = "Fruit",
                    Description = "Per unit",
                    Name = "Appelsienen",
                    Supplier = "De Haspengouwer"
                },
                new Product
                {
                    ProductId = 53,
                    Amount = 1,
                    Area = "Cleaning",
                    Soort = "General",
                    Description = "Per pak",
                    Name = "WC-papier",
                    Supplier = "Fris Doekske"
                },
                new Product
                {
                    ProductId = 54,
                    Amount = 1,
                    Area = "Cleaning",
                    Soort = "General",
                    Description = "Per pak",
                    Name = "WC-product",
                    Supplier = "Fris Doekske"
                },
                new Product
                {
                    ProductId = 55,
                    Amount = 1,
                    Area = "Cleaning",
                    Soort = "General",
                    Description = "Per unit",
                    Name = "Minibar bier",
                    Supplier = "Van Zon"
                },
                new Product
                {
                    ProductId = 56,
                    Amount = 1,
                    Area = "Cleaning",
                    Soort = "General",
                    Description = "Per unit",
                    Name = "Minibar Coca Cola",
                    Supplier = "Van Zon"
                },
                new Product
                {
                    ProductId = 57,
                    Amount = 1,
                    Area = "Cleaning",
                    Soort = "General",
                    Description = "Per unit",
                    Name = "Minibar Fanta",
                    Supplier = "Van Zon"
                },
                new Product
                {
                    ProductId = 58,
                    Amount = 1,
                    Area = "Other",
                    Soort = "Balie",
                    Description = "Per unit",
                    Name = "Papier printer",
                    Supplier = "Karlo"
                },
                new Product
                {
                    ProductId = 59,
                    Amount = 1,
                    Area = "Other",
                    Soort = "Balie",
                    Description = "Per unit",
                    Name = "Inkt printer",
                    Supplier = "Onbekend"
                },
                new Product
                {
                    ProductId = 60,
                    Amount = 1,
                    Area = "Other",
                    Soort = "Balie",
                    Description = "Per unit",
                    Name = "Nietjes",
                    Supplier = "De Standaard Boekhandel"
                },
                new Product
                {
                    ProductId = 61,
                    Amount = 1,
                    Area = "Other",
                    Soort = "Balie",
                    Description = "Per unit",
                    Name = "Enveloppes",
                    Supplier = "PrintSalon"
                }
            });
        }

    }
}
