using EFCmd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCmd.Context
{
    internal class StoreDbContext : DbContext
    {
        private const string connectionString = "Server=.\\SQLExpress;Database=StoreDb;Trusted_Connection=True"; //global private field
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Product> Products { get; set; }
    }
}
