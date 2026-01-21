using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverLoadAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values
            Employee employee1 = new Employee();
            employee1.Id = 1;
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";

            // Create the second Employee object and assign values
            Employee employee2 = new Employee();
            employee2.Id = 1;
            employee2.FirstName = "Test";
            employee2.LastName = "User";

            // Compare the two Employee objects using the overloaded == operator
            bool areEqual = employee1 == employee2;

            // Display the result of the comparison
            Console.WriteLine("Are the two employees equal? " + areEqual);

            // Pause the console so the output can be read
            Console.ReadLine();
        }
    }
}
