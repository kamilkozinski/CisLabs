using System;
namespace zad6

    //abstract class DirectorDecorator inherits from interface IDirector 

{
    public abstract class DirectorDecorator : IDirector
    {
        protected IDirector _director;

        public DirectorDecorator(IDirector director)
        {
            _director = director;
        }
        public virtual string NameAndSurname()
        {
            return _director.NameAndSurname();
        }
        public virtual double Salary()
        {
            return _director.Salary();
        }
        public virtual string Department()
        {
            return _director.Department();
        }
    }
}
