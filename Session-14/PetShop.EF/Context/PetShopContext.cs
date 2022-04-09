using Microsoft.EntityFrameworkCore;
using PetShopEFLibrary;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopEFLibrary
{
    internal class PetShopContext :DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<PetFood> PetFoods { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new EmpleyeeConfiguration());
            modelBuilder.ApplyConfiguration(new PetConfigurations());
            modelBuilder.ApplyConfiguration(new PetFoodConfigurations());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connString = @"Data Source = (localdb)\ProjectModels; Initial Catalog = DbPetShop; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
