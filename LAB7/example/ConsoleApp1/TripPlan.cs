using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class TripPlan
    {
        private List<ICommand> thingsToDo;
        public TripPlan()
        {
            thingsToDo = new List<ICommand>();
        }
        public void Add(ICommand thing)
        {
            thingsToDo.Add(thing);
        }
        public void Run()
        {
            foreach (ICommand com in thingsToDo)
            {
                com.Execute();
            }
        }
    }
}
