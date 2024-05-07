using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject1.Classes
{
    public class Genre
    {
        public int Id { get; set; }
        public string Genrees { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
