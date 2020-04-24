using System;
using System.Collections.Generic;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle Kolo = new Circle();
            Kolo.Diameter = 5;

            CarForSale myCar1 = new CarForSale("Fiat", "Seicento", 2000, 199999, true, 2100);
            CarForSale myCar2 = new CarForSale();
            CarForSale myCar3 = new CarForSale("Daewoo", "Lanos", 1998, 1500000, false, 3200);
            CarForSale myCar4 = new CarForSale("BMW", "X5", 2019, 10, false, 250000);

            List<CarForSale> carList = new List<CarForSale>();

            carList.Add(myCar1);
            carList.Add(myCar2);
            carList.Add(myCar3);
            carList.Add(myCar4);

            CarSaloon mySaloon = new CarSaloon(myCar4);

            Console.WriteLine(mySaloon.Car.PrintCarInfo());


           // foreach (var element in carList)
          //  {
            //    Console.WriteLine("Make:" + element.Make + " Model:" + element.Model + " Mileage:" + element.Mileage);

           // }

            // Console.WriteLine(Kolo.CalculateCircleArea());
        }
    }
}
