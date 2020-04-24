using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Dog : Animal
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
            Console.WriteLine("Woof");
        }
        public override string ToString()
        {
            return "This is a dog named " + Name + " that weighs " + Weight + " g.";
        }
    }
}
