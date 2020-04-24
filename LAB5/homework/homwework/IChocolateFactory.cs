using System;
using System.Collections.Generic;
using System.Text;

namespace homwework
{
    interface IChocolateFactory
    {
        public Treat CreateTreats(string m_name, int m_quantity, double m_calorie);

    }
}
