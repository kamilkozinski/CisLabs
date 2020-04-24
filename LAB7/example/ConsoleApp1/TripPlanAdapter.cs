using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TripPlanAdapter : IJourneyPlan
    {
        private TripPlan adaptee;
        public void Run(List<ICommand> list)
        {
            foreach (ICommand com in list)
            {
                adaptee.Add(com);
                com.Execute();
            }
        }
        public TripPlanAdapter()
        {
            adaptee = new TripPlan();
        }

    }
}
