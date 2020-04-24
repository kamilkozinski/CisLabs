using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class ConductanceAdapter : IResistance
    {
        private Conductance adaptee;

        public double Length
        {
            get;
            set;
        }
 
        public double Area
        {
            get;
            set;
        }
     
        public double Rho
        {
            get;
            set;
        }
        public double CalculateResistance()
        {
            Length = adaptee.L;
            Area = adaptee.A;
            Rho = 1/(adaptee.Sigma);
            return Rho * (Length/Area);
        }

        public ConductanceAdapter(Conductance adaptee)
        {
            this.adaptee = adaptee;
        }
    }
}
