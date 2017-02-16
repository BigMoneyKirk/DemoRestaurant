using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diner
{
    public class Restaurant
    {
        public Restaurant(string name, Address location, Menu ordermenu)
        {
            Name = name;
            Location = location;
            OrderMenu = ordermenu;
        }
        public string Name{ get; set; }
        public Address Location{ get; set; }
        public Menu OrderMenu{ get; set; }


    }
}
