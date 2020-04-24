using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class VisitCommand : ICommand
    {
        public TouristAttraction Attraction
        {
            get;
            set;
        }
        public int Hour
        {
            get;
            set;
        }
        public VisitCommand(TouristAttraction att, int h)
        {
            Attraction = att;
            Hour = h;
        }
        public void Execute()
        {
            Console.WriteLine(Attraction + "\r\n" + Hour + "Visiting " + Attraction.Name );
        }
    }
}
