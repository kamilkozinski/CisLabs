using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Cat : Animal
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
            Console.WriteLine("Meu Mau");
        }
        public override string ToString()
        {
            return "This is a cat named " + Name + " that weighs " + Weight + " g.";
        }

    }
}
