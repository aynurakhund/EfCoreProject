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
    public class WriterMap : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName)
                   .HasColumnType("nvarchar(50)")
                   .IsRequired();
            builder.Property(x=>x.LastName)
                  .HasColumnType("nvarchar(100)")
                  .IsRequired();

        }
    }
}
