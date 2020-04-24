using System;
using System.Collections.Generic;
using System.Text;

namespace homwework
{
    class BarFactory : IChocolateFactory 
    {
        public Treat CreateTreats(string m_name, int m_quantity, double m_calorie)
        {
            return new ChocolateBar(m_name, m_quantity, m_calorie);

        }
    }
}
