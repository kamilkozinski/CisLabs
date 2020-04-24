using System;

namespace lab1._2
{

    class Program
    {

        public static int Factorial(int n)
        {
            return n == 0 ? 1 : n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            RightTriangle trojkat = new RightTriangle();
            trojkat.A = 10;
            trojkat.B = 20;
            double obwod = trojkat.Circumfence;
           //int a;
            Console.WriteLine(obwod);
        }
    }
}
