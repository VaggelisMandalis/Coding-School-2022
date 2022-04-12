using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configuration
{
    internal class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.HasKey(transactionLine => transactionLine.ID);
            builder.Property(transactionLine => transactionLine.Quantity).HasPrecision(10);
            builder.Property(transactionLine =>transactionLine.ItemPrice).HasPrecision(10,3);
            builder.Property(transactionLine => transactionLine.NetValue).HasPrecision(10, 3);
            builder.Property(transactionLine => transactionLine.Discount).HasPrecision(10, 3);
            builder.Property(transactionLine => transactionLine.DiscountValue).HasPrecision(10, 3);
            builder.Property(transactionLine => transactionLine.TotalValue).HasPrecision(10, 3);


            builder.HasOne(transactionLine => transactionLine.Transaction).WithMany(transaction => transaction.TransactionLines).HasForeignKey(transactionline => transactionline.TransactionID);
            builder.HasOne(transline => transline.Item).WithMany(item => item.TransactionLines).HasForeignKey(transactionline => transactionline.ItemID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
