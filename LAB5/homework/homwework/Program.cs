using System;
using System.Collections.Generic;

namespace homwework
{
    class Program
    {
        static void Main(string[] args)
        {
            

           var productA = new SweetsFactory().CreateTreats("Maltesers", 100, 500);
           var productB = new BarFactory().CreateTreats("Snickers", 25, 345.2);
           var productC = new TruffleFactory().CreateTreats("Galaxy", 50, 444);

            Console.WriteLine(productA.PrintInfo());
            Console.WriteLine(productB.PrintInfo());
            Console.WriteLine(productC.PrintInfo());


        }
    }
}
