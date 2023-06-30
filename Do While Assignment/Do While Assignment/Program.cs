using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Guess a number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int correct_number1 = 12;
        bool guess1 = false;

        while (!guess1)
        {
            if (number1 == correct_number1)
            {
                Console.WriteLine("Correct!");
                guess1 = true;
                break;
            }
            else
            {
                Console.WriteLine("Incorrect! Guess again: ");
                number1 = Convert.ToInt32(Console.ReadLine());
            }
        }

        int correct_number2 = 24;
        bool guess2 = false;
        do
        {
            Console.WriteLine("Guess another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number2 == correct_number2)
            {
                Console.WriteLine("Correct! Nice job!");
                guess2 = true;
            }
        }
        while (!guess2);





        Console.Read();
    }
}

