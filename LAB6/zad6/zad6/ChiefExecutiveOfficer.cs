using System;
using System.Collections.Generic;
namespace zad6

    // Class ChiefExecutiveOfficer is a composite which contains classes Employee and Manager and combines their elements on 1 list

{
    public class ChiefExecutiveOfficer : IEmployee
    {
        private string firstName;
        private string lastName;
        private string position;

        private List<IEmployee> staff = new List<IEmployee>();
        public ChiefExecutiveOfficer(string firstname, string lastname, string position)
        {
            firstName = firstname;
            lastName = lastname;
            this.position = position;
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("CEO: " + firstName + " " + lastName);
            foreach(IEmployee employee in staff)
            {
                employee.DisplayEmployeeInfo();
            }
        }
        public void AddEmployee(IEmployee employee)
        {
            staff.Add(employee);
        }
    }
    
}
