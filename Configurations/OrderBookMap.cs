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
    public class OrderBookMap : IEntityTypeConfiguration<OrderBook>
    {
        public void Configure(EntityTypeBuilder<OrderBook> builder)
        {
            builder.HasKey(x => new { x.OrderId, x.BookId });
            builder.HasOne(x => x.Orders)
                   .WithMany(x => x.OrderBooks)
                   .HasForeignKey(x => x.OrderId);

            builder.HasOne(x=>x.Books)
                   .WithMany(x=>x.OrderBooks)
                   .HasForeignKey(x=>x.BookId);
        }
    }
}
