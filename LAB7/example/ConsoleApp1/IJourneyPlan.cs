using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IJourneyPlan
    {
        public void Run(List<ICommand> items);
    }
}
