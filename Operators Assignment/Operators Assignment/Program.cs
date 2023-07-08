using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employeeOne = new Employees() { Id = 001 };
            Employees employeeTwo = new Employees() { Id = 001 };

            if (employeeOne == employeeTwo)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

            Console.Read();
        }
    }
}
