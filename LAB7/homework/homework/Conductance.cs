using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Conductance
    {
        //length of the conductor [m]
        public double L
        {
            get;
            set;
        } 
        //cross section area of the conductor[m ^ 2]
        public double A
        {
            get;
            set;
        }
        //electrical conductivity [S * m^(-1)]
        public double Sigma
        {
            get;
            set;
        }

        public double CalculateConductance()
        {
            if (L > 0 && A > 0 && Sigma > 0)
            {
                return Sigma * (A / L);
            }
            return 0;
        }
        public Conductance(double m_length, double m_area, double m_sigma)
        {
            L = m_length;
            A = m_area;
            Sigma = m_sigma;
        }

    }
}
