using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopEFLibrary
{
    internal class PetFoodConfigurations : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
            builder.ToTable("PetFood");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID);
            builder.Property(x => x.Cost).HasPrecision(2);
            builder.Property(x => x.Price).HasPrecision(2);
            builder.Property(x => x.AnimalType);
            //builder.HasOne(PetFood => PetFood.PetShop).WithMany(PetShop => PetShop.PetFoods).HasForeignKey(PetFood => PetFood.ID);
        }
    }
}
