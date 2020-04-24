using System;
namespace zad6

    //class HRDirector inherits from IDirector
    //it's concrete class (1 of 3)

{
    public class HRDirector : IDirector
    {
       public virtual string NameAndSurname()
        {
            return "Mary White";
        }
        public virtual double Salary()
        {
            return 30000;
        }
        public virtual string Department()
        {
            return "Human Resources";
        }
    }
}
