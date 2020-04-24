using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TouristAttraction
    {
        public string Name
        {
            get;
            set;
        }
        public TouristAttraction(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Tickets reserverd for " + Name;
        }
    }
}
