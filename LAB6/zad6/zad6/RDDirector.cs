using System;
namespace zad6

    //class RDDirector inherits from IDirector
    //it's concrete class (2 of 3)

{
    public class RDDirector : IDirector
    {
        public virtual string NameAndSurname()
        {
            return "Steve Jobs";
        }
        public virtual double Salary()
        {
            return 30000;
        }
        public virtual string Department()
        {
            return "Research and Development";
        }
    }
}
