using EFCoreProject1.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject1.Context
{
    public class StoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=BookEFCore2;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Address> Addressess { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BookWriter> BookWriters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
