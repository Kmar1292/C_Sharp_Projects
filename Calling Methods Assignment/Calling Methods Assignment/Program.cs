using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer: ");
                int UserInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(UserInput + " + 42 equals " + MathOperations.Add42(UserInput));
                Console.WriteLine(UserInput + " * 3 equals " + MathOperations.Multiply3(UserInput));
                Console.WriteLine(UserInput + " % 2 equals " + MathOperations.Modulus2(UserInput));

                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
            


        }
    }
}
