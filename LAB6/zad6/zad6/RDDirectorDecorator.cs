using System;
namespace zad6

    //class RDDirectorDecorator inherits from DirectorDecorator
    //it's a decorator for class RDDirector (2 of 3)

{
    public class RDDirectorDecorator : DirectorDecorator
    {
        public RDDirectorDecorator(IDirector director) : base(director) { }

        public override string NameAndSurname()
        {
            return base.NameAndSurname();
        }
        public override double Salary()
        {
            return base.Salary() + 10000;
        }
        public override string Department()
        {
            return base.Department();
        }
    }
}
