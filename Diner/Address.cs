using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diner
{
    public class Address
    {
        public Address(string street, string city, string state, int zipcode)
        {
            Street = street;
            City = city;
            State = state;
            Zipcode = zipcode;
        }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
    }
}
