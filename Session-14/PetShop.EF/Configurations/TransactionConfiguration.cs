using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopEFLibrary
{
    internal class TransactionConfiguration:IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID);
            builder.Property(x => x.PetFoodQty);
            builder.Property(x => x.PetFoodPrice);
            builder.Property(x => x.PetPrice).HasPrecision(2);
            builder.Property(x => x.TotalPrice).HasPrecision(2);
            builder.Property(x => x.CustomerID);
            builder.Property(x => x.EmployeeID);
            builder.Property(x => x.Date);
            builder.Property(x => x.PetFoodID);
            builder.Property(x => x.PetID);
        }
    }
}
