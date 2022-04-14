using FuelStation.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configuration
{
    public class LoginsConfiguration : IEntityTypeConfiguration<Logins>
    {
        public void Configure(EntityTypeBuilder<Logins> builder)
        {
            builder.HasKey(logins => logins.ID);
            builder.Property(logins => logins.ID).ValueGeneratedOnAdd();
            builder.Property(logins => logins.LoginName).IsRequired();
            builder.Property(logins => logins.Password).IsRequired();
            builder.Property(logins => logins.LoginName).HasMaxLength(50);
            builder.Property(logins => logins.Password).HasMaxLength(50);

        }
    }
}
