using System;
namespace zad6

    //class Manager inherits from interface IEmployee
    // it's concrete class

{
    public class Manager : IEmployee
    {
        private string firstName;
        private string lastName;
        private string position;

        public Manager(string firstname, string lastname, string position)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.position = position;
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Manager: " + firstName + " " + lastName);
        }
    }
}
