using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Library
{
    public class Person
    {
        private string Name { get; set; }
        private string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public override string ToString()
        {
            return ($"{GetName()}, {GetAddress()}");
        }
        public string GetName()
        {
            return Name;
        }

        public string GetAddress()
        {
            return Address;
        }
    }

    
}
