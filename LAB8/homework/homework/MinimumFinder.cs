using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class MinimumFinder
    {
        private IFindMinimum _strategy;

        public MinimumFinder()
        { }

        public MinimumFinder(IFindMinimum strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IFindMinimum strategy)
        {
            _strategy = strategy;
        }
        public int FindMin(List<int> list)
        {
            var result = _strategy.FindMin(list);
            return result;
        }

    }
}
