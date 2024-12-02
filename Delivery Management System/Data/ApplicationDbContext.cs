using Delivery_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Delivery_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<DeliveryItem> DeliveryItem { get; set; }
        public object Deliveries { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MyDb;Trusted_Connection=True;");
        }
    }
}