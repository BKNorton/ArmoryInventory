using ArmoryInventory.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventory.Data
{
    public class ArmoryInventoryDbContext : DbContext
    {
        //public string DbPath { get; set; }
        public ArmoryInventoryDbContext()
        {
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //DbPath = Path.Combine(path, "ArmoryInventory2_EfCore.db");
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite($"Data Source={DbPath}")
            optionsBuilder.UseSqlite($"Data Source=C:\\Users\\Kirk\\source\\repos\\ArmoryInventory\\ArmoryInventory.Data\\Database\\ArmoryInventory.db")
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
