using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The time in {0} hours will be: " + DateTime.Now.AddHours(number), number);

            Console.Read();
        }
    }
}
