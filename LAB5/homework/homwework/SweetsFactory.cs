using System;
using System.Collections.Generic;
using System.Text;

namespace homwework
{
    class SweetsFactory : IChocolateFactory
    {
        public Treat CreateTreats(string m_name, int m_quantity, double m_calorie)
        {
            return new Sweet(m_name, m_quantity, m_calorie);
            
        }
    }
}
