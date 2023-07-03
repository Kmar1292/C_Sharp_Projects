using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> integer_list = new List<int>() { 5, 7, 21, 76, 42, 99, 33 };
            Console.WriteLine("Input a number to divide the list by: ");
            int user_input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < integer_list.Count; i++)
            {
                Console.WriteLine(integer_list[i] / user_input);
            }
            Console.Read();
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("This message is outside the try/catch block.");
        Console.Read();

    }
}

