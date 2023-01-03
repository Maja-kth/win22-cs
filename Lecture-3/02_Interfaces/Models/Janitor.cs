using _02_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interfaces.Models
{
    internal class Janitor : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string StreetName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
