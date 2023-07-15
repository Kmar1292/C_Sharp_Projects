using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>();
            employee.things.Add("car");
            employee.things.Add("bike");
            employee.things.Add("toilet");

            Employee<int> employeeTwo = new Employee<int>();
            employeeTwo.things = new List<int>();
            employeeTwo.things.Add(3);
            employeeTwo.things.Add(12);
            employeeTwo.things.Add(42);

            List<Employee<T>> myList = new List<Employee<T>>();

            foreach (string thing in employee.things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employeeTwo.things)
            {
                Console.WriteLine(thing);
            }

            Console.Read();
        }
    }
}
