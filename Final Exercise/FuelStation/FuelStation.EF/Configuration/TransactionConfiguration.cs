﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static FuelStation.Models.Entities.Enums;

namespace FuelStation.EF.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.Date).IsRequired();
            builder.Property(transaction => transaction.PaymentMethod).HasConversion(paymentMethod => paymentMethod.ToString(), paymentMethod => (PaymentMethod)Enum.Parse(typeof(PaymentMethod), paymentMethod)).HasMaxLength(15);
            builder.Property(transaction => transaction.TotalValue).HasColumnType("decimal(10,3)");
            builder.HasOne(transaction => transaction.Employee).WithMany(employee => employee.Transactions).HasForeignKey(transaction => transaction.EmployeeID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(transaction => transaction.Customer).WithMany(customer => customer.Transactions).HasForeignKey(transaction => transaction.CustomerID).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
