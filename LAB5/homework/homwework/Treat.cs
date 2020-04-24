using System;
using System.Collections.Generic;
using System.Text;

namespace homwework
{
   abstract class Treat
    {
        public string Name
        {
            get;
            set;
        }
        public int QuantityInBox
        {
            get;
            set;
        }
        public double CaloriesPer100g
        {
            get;
            set;
        }
        public abstract string PrintInfo();


    }
}
