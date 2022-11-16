using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Address
    {
        public string street;
        public string city;
        public string state;
        public string postalCode;
        public string country;
        private bool validate() { return true; }
        public string outputAsLabel() {return (street + " " + city + " " + state + " " + postalCode + " " + country); }
    }
}
