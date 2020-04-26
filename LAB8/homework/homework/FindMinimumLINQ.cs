using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace homework
{
    class FindMinimumLINQ : IFindMinimum
    {
        public int FindMin(List<int> list)
        {
            return list.Min();
        }


    }
}
