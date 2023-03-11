using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // Context nesnedi db tabloları ile proje class larını ilişkilendirmek için kullanılır.
    public class NorthwindContext:DbContext
    {
        // Hangi veritabanı ile çalıştığını göstermek için.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=desktop-vbc9noo\sqlexpress;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
