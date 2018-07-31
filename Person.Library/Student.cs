using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Library
{
    public class Student : Person
    {   
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Year = year;
            Program = program;
            Fee = fee;
        }

        public override string ToString()
        {
            return ($"{GetName()},{GetAddress()},{Year}, {Program}, {Fee}");
        }

        


    }
}
 