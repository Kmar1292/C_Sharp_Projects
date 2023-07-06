using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate MathOperations obj
            MathOperations ops = new MathOperations();
            Console.WriteLine("Enter an integer: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            //Ask user for optional int. If input is not an integer, the format exception will direct the program to only pass 1 arg into the Operations method
            try
            {
                Console.WriteLine("Enter another optional integer: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("(" + number1 + " / 2) + (" + number2 + " * 2) = " + ops.Operations(number1, number2));
            }
            catch (FormatException)
            {
                Console.WriteLine(number1 + " / 2 = " + ops.Operations(number1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
