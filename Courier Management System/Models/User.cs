using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_System.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string CreditCard { get; set; }
        public string Major { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
       
    }
}
