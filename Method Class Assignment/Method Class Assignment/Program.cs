using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating VoidMethod obj
            VoidMethod testing = new VoidMethod();
            Console.WriteLine("Input an integer: ");
            int input1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another integer: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            testing.test(num1: input1, num2: input2);

            Console.Read();
        }
    }
}
