using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    interface IResistance
    {
        //length of the conductor [m]
        public double Length
        {
            get;
            set;
        }
        // cross section area of the conductor [m^2]
        public double Area
        {
            get;
            set;
        }
        //electrical resistivityy [Ohm * m]
        public double Rho
        {
            get;
            set;
        }

        public double CalculateResistance();
       
      
    }
}
