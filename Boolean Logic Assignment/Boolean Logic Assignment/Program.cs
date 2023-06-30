using System;

    class Program
    {
        static void Main()
        {
        //Get user info
        Console.WriteLine("What is your age?");
        string userAgeString = Console.ReadLine();
        int userAge = Convert.ToInt32(userAgeString);

        Console.WriteLine("Have you ever had a DUI? Please write \"True\" or \"False\"");
        string userDUIString = Console.ReadLine();
        bool userDUI = Convert.ToBoolean(userDUIString);

        Console.WriteLine("How many speeding tickets do you have?");
        string userSpeedingTicketsString = Console.ReadLine();
        int userSpeedingTickets = Convert.ToInt32(userSpeedingTicketsString);

        //Check validity of user
        bool validAge = (userAge > 15);
        bool validDUI = (userDUI == false);
        bool validSpeedingTickets = (userSpeedingTickets <= 3);

        //Print result of validity check
        bool userValid = (validAge && validDUI && validSpeedingTickets);
        Console.WriteLine("Qualified?");
        Console.WriteLine(userValid);

        Console.Read();
        }
    }

