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
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName)
                   .HasColumnType("nvarchar(50)")
                   .IsRequired();
            builder.Property(x => x.LastName)
                   .HasColumnType("nvarchar(100)")
                   .IsRequired();
           
        }
    }
}
