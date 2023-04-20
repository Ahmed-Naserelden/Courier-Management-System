using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_System.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public User AdminstratorDriver { get; set; }
        public int Size { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }

    }
}
