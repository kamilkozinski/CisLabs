using System;
namespace zad6

    // interface IDirector (prepared for decorator)

{
    public interface IDirector
    {
        public abstract string NameAndSurname();
        public abstract double Salary();
        public abstract string Department();
    }
}
