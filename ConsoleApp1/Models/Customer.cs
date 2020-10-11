using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
#nullable enable
        public string? Email { get; set; }
        public string? Phone { get; set; }
#nullable restore

        public ICollection<Order> Orders { get; set; }
    }
}
