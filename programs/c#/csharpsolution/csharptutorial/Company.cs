using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutorial
{
    internal class Company
    {
        //attributes
        public string code;
        public string name;
        public string address;
        public string location;
        public int noofemp;

        public Company()
        {
            Console.WriteLine("Default constructor");
        }

        public Company(string code, string name, string address, string location, int noofemp)
        {
            Console.WriteLine("Parameterized constructor");
            this.code = code;
            this.name = name;
            this.address = address;
            this.location = location;
            this.noofemp = noofemp;            
        }

        // functionality
        public void Information()
        {
            Console.WriteLine($" Name : {name} Location : {location}");
        }
    }
}
