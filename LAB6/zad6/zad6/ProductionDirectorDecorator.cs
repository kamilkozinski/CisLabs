using System;
namespace zad6

    //class ProductionDirectorDecorator inherits from DirectorDecorator
    //it's a decorator of class ProductionDirector (3 of 3)

{
    public class ProductionDirectorDecorator : DirectorDecorator
    {
        public ProductionDirectorDecorator(IDirector director) : base(director) { }

        public override string NameAndSurname()
        {
            return base.NameAndSurname();
        }
        public override double Salary()
        {
            return base.Salary() + 15000;
        }
        public override string Department()
        {
            return base.Department();
        }
    }
}
