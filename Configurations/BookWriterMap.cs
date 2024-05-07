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
    public class BookWriterMap : IEntityTypeConfiguration<BookWriter>
    {
        public void Configure(EntityTypeBuilder<BookWriter> builder)
        {
            builder.HasKey(x => new { x.BookId,x.WriterId});
            builder.HasOne(x => x.Books)
                   .WithMany(x => x.BookWriters)
                   .HasForeignKey(x => x.BookId);
            builder.HasOne(x => x.writers)
                    .WithMany(x => x.BookWriters)
                    .HasForeignKey(x => x.WriterId);
        }
    }
}
