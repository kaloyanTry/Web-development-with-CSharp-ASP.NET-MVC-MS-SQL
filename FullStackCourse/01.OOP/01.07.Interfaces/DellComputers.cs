using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class DellComputers : InterfaceComputer, InterfacesMultipleDellComputer
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Mark { get; set; }

        public void GetDesktops()
        {
            Name = "Desktop Dell, i5, 8RAM";
            Price = 580;
        }

        public void GetLaptops()
        {
            Name = "Laptop Dell, i5, 16RAM";
            Price = 1300;
        }

        public void GetMark()
        {
            Mark = "Dell";
        }
    }
}
