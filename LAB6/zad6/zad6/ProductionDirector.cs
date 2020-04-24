using System;
namespace zad6

    //class ProductionDirector inherits from IDIrector
    //it's concrete class (3 of 3)

{
    public class ProductionDirector : IDirector
    {
        public string NameAndSurname()
        {
            return "Mark Black";
        }
        public double Salary()
        {
            return 30000;
        }
        public string Department()
        {
            return "Production";
        }
    }
}
