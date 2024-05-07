using EFCoreProject1.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject1.Configurations
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Addres)
                .HasColumnType("nvarchar(80)")
                .IsRequired();
            builder.HasMany(x => x.Customers)
                   .WithOne(x => x.Addressess)
                   .HasForeignKey(x => x.AddressId);
        }
    }
}
