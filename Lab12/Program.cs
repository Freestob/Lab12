using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons.Library;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listofPersons = new List<Person>
            {
                 new Student("Bradley Freestone", "Wealthy St", "Boot Camp", 2018, 8750),
                 new Staff("Brian Gardner", "Monroe Ave", "Grand Circus", 250000),
                 new Person("Buttface McButtface", "Arse Lane")
            };
           
            foreach(Person x in listofPersons)
            {
                Console.WriteLine(x.ToString());
            }
            Console.ReadLine();
        }
    }
}
