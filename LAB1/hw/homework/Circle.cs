using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Circle
    {
        private double diameter;

        public double Diameter
        {
            get { return diameter; }
            set
            {
                if (value > 0) diameter = value;
            }

        }
        public double Perimeter
        {
            get
            {
                return 2 * Math.PI * CalculateRadius();
            }
        }

        private double CalculateRadius()
        {
            return Diameter / 2;
        }
        public double CalculateCircleArea()
        {

            return Math.PI * CalculateRadius() * CalculateRadius();
        }


    }
}
