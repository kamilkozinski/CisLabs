using System;

namespace Lab1
{
    class Program
    {
        static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {

                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;

        }

        static int myFactorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;

            }
            return num * myFactorial(num - 1);

        }

        static void PrintFactorial(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("Nie mozna obliczyc silni z ujemnej liczby");
            }
            else
            {
                int temp = myFactorial(num);
                Console.WriteLine("Silnia z " + num + " wynosi " + temp);
            }


        }

        static void Main(string[] args)
        {

            int usersNumber;
            Console.WriteLine("Podaj liczbę");
            usersNumber = Convert.ToInt32(Console.ReadLine());
            PrintFactorial(usersNumber);
            /*
            bool temp;
            for (int i = 2; i <= 100; i++)
            {
                temp = IsPrime(i);
                Console.WriteLine("Number " + i + " is prime: " + temp);
            }
            */



        }
    }
}
