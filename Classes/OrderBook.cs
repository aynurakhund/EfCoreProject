using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject1.Classes
{
    public class OrderBook
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public Book Books { get; set; }
        public Order Orders { get; set; }
    }
}
