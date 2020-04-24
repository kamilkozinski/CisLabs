using System;
namespace zad6

    // class Employee inherits from interface IEmployee
    // it's concrete class

{
    public class Employee : IEmployee
    {
        private string firstName;
        private string lastName;
        private string position;

        public Employee(string firstname, string lastname, string position)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.position = position;
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine(firstName + " " + lastName + " - " + position);
        }
    }
}
