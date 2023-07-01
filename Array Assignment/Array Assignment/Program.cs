using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //STRING ARRAY
        string[] string_array = { "Kevin", "Andrew", "Vincent", "Lena", "Michaela" };
        int string_array_length = string_array.Length;
        Console.WriteLine("Enter the index of the string array between 0 and " + (string_array_length - 1) + " that you would like to be displayed: ");
        int string_index = Convert.ToInt32(Console.ReadLine());

        //If input is invalid, re-prompt user for a correct input
        while (string_index > (string_array_length - 1) || string_index < 0)
        {
            Console.WriteLine("Please input a value between 0 and " + (string_array_length - 1) + ": ");
            string_index = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(string_array[string_index]);

        //INT ARRAY
        int[] int_array = { 12, 24, 31, 92 };
        int int_array_length = int_array.Length;
        Console.WriteLine("Enter the index of the int array between 0 and " + (int_array_length - 1) + " that you would like to be displayed: ");
        int int_index = Convert.ToInt32(Console.ReadLine());

        //If input is invalid, re-prompt user for a correct input
        while (int_index > (int_array_length - 1) || int_index < 0)
        {
            Console.WriteLine("Please input a value between 0 and " + (int_array_length - 1) + ": ");
            int_index = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(int_array[int_index]);

        //STRING LIST
        List<string> string_list = new List<string>();
        string_list.Add("Red");
        string_list.Add("Blue");
        string_list.Add("Yellow");
        string_list.Add("Green");
        int string_list_length = string_list.Count;
        Console.WriteLine("Enter the index of the string list between 0 and " + (string_list_length - 1) + " that you would like to be displayed: ");
        int string_list_index = Convert.ToInt32(Console.ReadLine());

        //If input is invalid, re-prompt user for a correct input
        while (string_list_index > (string_list_length - 1) || string_list_index < 0)
        {
            Console.WriteLine("Please input a value between 0 and " + (string_list_length - 1) + ": ");
            string_list_index = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(string_list[string_list_index]);

        Console.Read();
    }
}

