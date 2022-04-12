using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FuelStation.Models.Entities;
using Microsoft.EntityFrameworkCore;
using FuelStation.Models;
using static FuelStation.Models.Entities.Enums;

namespace FuelStation.EF.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.Name).HasMaxLength(50);
            builder.Property(employee => employee.Surname).HasMaxLength(50);
            builder.Property(employee => employee.SallaryPerMonth).HasPrecision(10, 2);
            builder.Property(employee => employee.EmployeeType).HasConversion(employeeType => employeeType.ToString(), employeeType => (EmployeeType)Enum.Parse(typeof(EmployeeType), employeeType)).HasMaxLength(15);
            builder.Property(employee => employee.HireDateStart).IsRequired();
            builder.HasMany(employee => employee.Transactions)
                .WithOne(transaction => transaction.Employee)
                .HasForeignKey(transaction => transaction.EmployeeID);
        }
    }
}
