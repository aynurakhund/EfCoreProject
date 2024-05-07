using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject1.Classes
{
    public class Address
    {
        public int Id { get; set; }
        public string Addres { get; set; }
        public ICollection<Customer> Customers { get; set; }

    }
}
