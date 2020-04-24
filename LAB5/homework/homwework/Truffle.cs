using System;
using System.Collections.Generic;
using System.Text;

namespace homwework
{
    class Truffle : Treat
    {
        new public  string Name
        {
            get;
            set;
        }
       new public int  QuantityInBox
        {
            get;
            set;
        }
       new  public double CaloriesPer100g
        {
            get;
            set;
        }
        public Truffle(string m_name, int m_quantity, double m_calories)
        {
            Name = m_name;
            QuantityInBox = m_quantity;
            CaloriesPer100g = m_calories;
        
        }
        public Truffle()
        {
            Name ="";
            QuantityInBox = 0;
            CaloriesPer100g = 0;

        }
        public override string PrintInfo()
        {
            return "This is Truffle " + Name + " that contains " + QuantityInBox + " pieces in box and has " + CaloriesPer100g + " cal per 100g. ";
        }


    }
}
