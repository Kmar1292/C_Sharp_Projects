using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate MathOperations
            MathOperations mathOperations = new MathOperations();

            //Have user input integer and pass integer into Operation method
            Console.WriteLine("Enter an integer: ");
            int intInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intInput + " + 12 equals " + mathOperations.Operation(intInput));

            //Have user input float and pass float into Operation method
            Console.WriteLine("Enter a decimal number: ");
            float floatInput = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(floatInput + " / 3 equals " + mathOperations.Operation(floatInput));

            //Have user input integer and pass STRING into Operation method
            Console.WriteLine("Enter an integer: ");
            string stringInput = Console.ReadLine();
            try
            {
                Console.WriteLine(stringInput + " times 4 equals " + mathOperations.Operation(stringInput));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
