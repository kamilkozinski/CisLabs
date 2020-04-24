using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Fish : Animal
    {
        public string Name
        {
            get;
            set;
        }
        public double Weight
        {
            get;
            set;
        }
        public override void MakeNoise()
        {
            Console.WriteLine("BulBulBul");
        }
        public override string ToString()
        {
            return "This is a fish named " + Name + " that weighs " + Weight + " g.";
        }
    }

}
