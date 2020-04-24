using System;
using System.Collections.Generic;
using System.Text;

namespace homwework
{
    class TruffleFactory : IChocolateFactory
    {
        public Treat CreateTreats(string m_name, int m_quantity, double m_calorie)
        {
            return new Truffle(m_name, m_quantity, m_calorie);

        }
    }
}
