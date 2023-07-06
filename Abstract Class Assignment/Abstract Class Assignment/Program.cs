using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            employee.SayName();
            employee.Quit();

            //Polymorphism
            IQuittable quitter = new Employee();
            quitter.Quit();

            Console.Read();
        }
    }
}
