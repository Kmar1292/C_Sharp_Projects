using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiating TestClass obj
            TestClass test = new TestClass();
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            //using void method from TestClass that displays integer
            test.TestMethod(num);

            //using method that outputs an integer into x
            int x = 0;
            staticClass.outputParam(num, out x);
            Console.WriteLine(x);

            //overloaded outputParam method so that it can take one or two integer arguments
            Console.WriteLine("Enter a second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            staticClass.outputParam(num, num2, out x);
            Console.WriteLine(x);

            Console.Read();
        }

        //static class
        public static class staticClass
        {
            public static void outputParam(int number, out int output)
            {
                output = number + 2;
            }

            public static void outputParam(int number1, int number2, out int output)
            {
                output = number1 + number2;
            }
        }
    }
}
