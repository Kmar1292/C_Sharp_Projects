using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create string array, ask user for string input
        string[] string_array = { "Random", "Text", "Hello", "Five", "Navy Blue" };
        Console.WriteLine("Input some text: ");
        string user_input = Console.ReadLine();

        //iterate through string array and add user's string input to each value, then display it
        for (int i = 0; i < string_array.Length; i++)
        {
            string_array[i] = string_array[i] + user_input;
            Console.WriteLine(string_array[i]);
        }

        //infinite loop
        int loop_number = 3;
        int user_guess;
        bool loop_flag = false;
        Console.WriteLine("I'm thinking of a number between 1-10. Try to guess it!");
        while (loop_flag == false)
        {
            user_guess = Convert.ToInt32(Console.ReadLine());
            if (user_guess == loop_number)
            {
                Console.WriteLine("Correct! Good job!");
                loop_flag = true;   //If this line wasn't here this loop would go infinitely because loop_flag would never get changed from false to true. 
            }
            else
            {
                Console.WriteLine("Incorrect! Guess again!");
            }
        }

        //loop using the < operator
        int countUp = 1;
        do
        {
            Console.WriteLine(countUp);
            countUp++;
        }
        while (countUp < 11);

        //loop using the <= operator
        countUp = 1;
        do
        {
            Console.WriteLine(countUp);
            countUp++;
        }
        while (countUp <= 10);

        //List of unique strings
        List<string> names = new List<string>() { "Kevin", "Andrew", "Vincent", "Lena", "Michaela" };
        Console.WriteLine("Enter the name you want to search for: ");
        string user_search = Console.ReadLine();

        //if list contains user's search
        if (names.Contains(user_search))    
        {
            //iterate through each name in the list
            for (int i = 0; i < names.Count; i++)
            {
                //if user's search matches the current name in the list
                if (user_search == names[i])
                {
                    //this break statement exits the loop once a matching name is found
                    //break;
                    //display the index of the name in the list
                    Console.WriteLine("The index of the name you searched for is: " + i);
                }
            }
        }
        //if list does not contain user's search
        else
        {
            //display that it was not found in the list
            Console.WriteLine("The name you searched for does not exist in the list."); 
        }

        //List of strings that have some duplicates
        List<string> names2 = new List<string>() { "Kevin", "Andrew", "Vincent", "Lena", "Michaela", "Kevin", "Vincent", "Andrew", "Lena", "Michaela" };
        Console.WriteLine("Enter the name you want to search for: ");
        string user_search2 = Console.ReadLine();

        //if list contains user's search
        if (names2.Contains(user_search2))
        {
            //iterate through each name in the list
            for (int i = 0; i < names2.Count; i++)
            {
                //if user's search matches the current name in the list
                if (user_search2 == names2[i])
                {
                    //display the index of the name in the list
                    Console.WriteLine("The index of the name you searched for is: " + i);
                }
            }
        }
        //if list does not contain user's search
        else
        {
            //display that it was not found in the list
            Console.WriteLine("The name you searched for does not exist in the list.");
        }

        //New list with grocery items, tomatoes is duplicated
        List<string> grocery_list = new List<string>() { "Eggs", "Tomatoes", "Bananas", "Chicken", "Lettuce", "Bread", "Tomatoes", "Mushrooms", "Eggs" };
        //Create empty list to pass items into. Goal is to iterate through each item in grocery list, if test list already contains item that means it's a duplicate. If test list does not contain the item, then it is a first.
        List<string> grocery_list_test = new List<string>();

        //For each item in grocery list
        foreach (string item in grocery_list)
        {
            //if test list contains item
            if (grocery_list_test.Contains(item))
            {
                Console.WriteLine(item + ": This item has already appeared in the list.");
            }
            //if test list does not contain item
            else
            {
                //add item to test list
                grocery_list_test.Add(item);
                Console.WriteLine(item);
            }

        }

        Console.Read();
    }
}

