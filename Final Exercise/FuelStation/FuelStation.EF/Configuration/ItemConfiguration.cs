using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FuelStation.Models.Entities;
using Microsoft.EntityFrameworkCore;
using static FuelStation.Models.Entities.Enums;

namespace FuelStation.EF.Configuration
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(item => item.ID);
            builder.Property(item => item.Code).HasMaxLength(30).IsRequired();
            builder.HasIndex(item => item.Code).IsUnique();
            builder.Property(item => item.Description).HasMaxLength(100);
            builder.Property(item => item.ItemType).HasConversion(itemType => itemType.ToString(), itemType => (ItemType)Enum.Parse(typeof(ItemType), itemType)).HasMaxLength(15);
            builder.Property(item => item.Price).HasPrecision(10, 3);
            builder.Property(item => item.Cost).HasPrecision(10, 3);
        }
    }
}
