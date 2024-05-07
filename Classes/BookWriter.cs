using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject1.Classes
{
    public class BookWriter
    {
        public int BookId { get; set; }
        public int WriterId { get; set; }
        public Book Books { get; set; }
        public Writer writers { get; set; }
    }
}
