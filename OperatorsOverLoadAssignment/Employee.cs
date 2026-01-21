using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverLoadAssignment
{
    // Employee class definition
    class Employee
    {
        // Public property to store the employee's ID
        public int Id { get; set; }

        // Public property to store the employee's first name
        public string FirstName { get; set; }

        // Public property to store the employee's last name
        public string LastName { get; set; }

        // Overload the == operator to compare two Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects reference the same memory location, they are equal
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If either object is null, they are not equal
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare the Id properties of both Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (must be done in pairs with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite result of the == operator
            return !(emp1 == emp2);
        }

        // Override Equals to keep consistency with the overloaded == operator
        public override bool Equals(object obj)
        {
            // If the object is not an Employee, return false
            if (!(obj is Employee))
                return false;

            // Cast the object to Employee
            Employee other = (Employee)obj;

            // Compare the Id properties
            return this.Id == other.Id;
        }

        // Override GetHashCode when Equals is overridden
        public override int GetHashCode()
        {
            // Use the Id property to generate the hash code
            return Id.GetHashCode();
        }
    }
}
