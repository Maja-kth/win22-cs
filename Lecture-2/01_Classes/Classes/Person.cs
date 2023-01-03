using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes.Classes
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string DisplayName => $"{FirstName} {LastName}";

    }
}
