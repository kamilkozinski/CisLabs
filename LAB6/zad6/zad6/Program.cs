using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Composites: ");
            ChiefExecutiveOfficer ceo = new ChiefExecutiveOfficer("Jaroslaw", "K.", "King of Poland");
            ceo.AddEmployee(new Manager("Jack", "Daniels", "Waiter"));
            ceo.AddEmployee(new Employee("Andrew", "D.", "Teddy bear"));
            ceo.AddEmployee(new Employee("Johnny", "Walker", "Journalist"));
            ceo.DisplayEmployeeInfo();

            Console.WriteLine();

            Console.WriteLine("Decorators: (basic salary is 30000)");
            IDirector directorA = new HRDirector();     //creating objects of concrete classes
            IDirector directorB = new RDDirector();
            IDirector directorC = new ProductionDirector();
            directorA = new HRDirectorDecorator(directorA);     //redirecting objects of concrete classes to different decorators
            directorB = new RDDirectorDecorator(directorB);
            directorC = new ProductionDirectorDecorator(directorC);
            Console.WriteLine("Salary of " + directorA.Department() + " director: " + directorA.Salary());  //HRDirector salary is 5000 higher than basic
            Console.WriteLine("Salary of " + directorB.Department() + " director: " + directorB.Salary());  //RDDirector salary is 10000 higher than basic 
            Console.WriteLine("Salary of " + directorC.Department() + " director: " + directorC.Salary());  //ProductionDirector salary is 150000 higher than basic

            Console.ReadKey();
        }
    }
}
