using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopEFLibrary
{
    internal class EmpleyeeConfiguration : IEntityTypeConfiguration<Employee>  
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.SurName).HasMaxLength(50);
            builder.Property(x => x.SalaryPerMonth);
            builder.Property(x => x.EmployeeType);
        }
    }
}
