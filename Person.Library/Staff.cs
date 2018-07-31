using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Library
{
    public class Staff : Person
    {
        public string School;
        public double Pay;

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }
        public override string ToString()
        {
            return ($"{GetName()},{GetAddress()},{School}, {Pay}");
        }
    }
}
