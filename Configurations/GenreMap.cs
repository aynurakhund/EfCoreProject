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
    public class GenreMap : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Genrees)
                   .HasColumnType("nvarchar(20)")
                   .IsRequired();
            builder.HasMany(x => x.Books)
                    .WithOne(x => x.Genre)
                    .HasForeignKey(x => x.GenreId);
        }
    }
}
