using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class FindMinimumByLoop : IFindMinimum
    {
        public int minimum = int.MaxValue;
        public int FindMin(List<int> list)
        {
            
            foreach (int i in list)
            {
                if (i <= minimum)
                    minimum = i;
            }
            return minimum;
        }
    }
}
