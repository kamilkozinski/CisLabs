using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TouristAttraction schonbrun = new TouristAttraction("Schonnbr");
            TouristAttraction museum = new TouristAttraction("museum");
            VisitCommand visitshron = new VisitCommand(schonbrun, 11);
            VisitCommand visitmuseum = new VisitCommand(museum, 12);

            TripPlan planA = new TripPlan();

            TripPlanAdapter tpa = new TripPlanAdapter();
            tpa.Run(new List<ICommand>() { visitmuseum, visitshron });



        }
    }
}
