using System;
using System.Collections.Generic;
namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal bla = new Animal();

            Animal goldFish = new Fish()
            {
                Name = "Bubbles",
                Weight = 50
            };
            Animal goldenRetriever = new Dog()
            {
                Name = "Julian",
                Weight = 30000

            };
            Animal maineCoon = new Cat()
            {
                Name = "Ricky",
                Weight = 15000

            };

            List <Animal> myAnimals = new List<Animal>();
            myAnimals.Add(maineCoon);
            myAnimals.Add(goldenRetriever);
            myAnimals.Add(goldFish);

            foreach (Animal x in myAnimals)
            {
                Console.WriteLine(x);
                x.MakeNoise();
            }


            Warship orzel = new Warship()
            {
                PosX = 0,
                PosY = 0,
                Health = 100
            };
            Warship wrona = new Warship()
            {
                PosX = 0,
                PosY = 0,
                Health = 100
            };

            orzel.Move(5, 2);
            Console.WriteLine(orzel.PosX);
            Console.WriteLine(orzel.PosY);

            orzel.Attack(wrona, 40);

            Console.WriteLine(wrona.Health);


        }
    }
}
