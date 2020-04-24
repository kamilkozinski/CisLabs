using System;
namespace zad6

    //class HRDirecorDecorator inherits from DirectorDecorator
    //it's a decorator for class HRDirector (1 of 3)

{
    public class HRDirectorDecorator : DirectorDecorator
    {
        public HRDirectorDecorator(IDirector director) : base(director) { }

        public override string NameAndSurname()
        {
            return base.NameAndSurname();
        }
        public override double Salary()
        {
            return base.Salary()+5000;
        }
        public override string Department()
        {
            return base.Department();
        }
    }
}
