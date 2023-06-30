using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Anonymous Income Comparison Program");

        //Get Person 1's info
        Console.WriteLine("Person 1: ");
        Console.WriteLine("Hourly Rate: ");
        string person1_HourlyRateString = Console.ReadLine();
        float person1_HourlyRate = Convert.ToSingle(person1_HourlyRateString);
        Console.WriteLine("Hours worked per week: ");
        string person1_HoursWorkedString = Console.ReadLine();
        float person1_HoursWorked = Convert.ToSingle(person1_HoursWorkedString);

        //Get Person 2's info
        Console.WriteLine("Person 2: ");
        Console.WriteLine("Hourly Rate: ");
        string person2_HourlyRateString = Console.ReadLine();
        float person2_HourlyRate = Convert.ToSingle(person2_HourlyRateString);
        Console.WriteLine("Hours worked per week: ");
        string person2_HoursWorkedString = Console.ReadLine();
        float person2_HoursWorked = Convert.ToSingle(person2_HoursWorkedString);

        //Calculate and print annual salaries of both people
        Console.WriteLine("Annual salary of Person 1: ");
        const int weeksInYear = 52;
        float person1_annualSalary = weeksInYear * person1_HoursWorked * person1_HourlyRate;
        Console.WriteLine(person1_annualSalary);

        Console.WriteLine("Annual salary of Person 2: ");
        float person2_annualSalary = weeksInYear * person2_HoursWorked * person2_HourlyRate;
        Console.WriteLine(person2_annualSalary);

        //Compare salaries
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        bool person1_greaterthan_person2 = person1_annualSalary > person2_annualSalary;
        Console.WriteLine(person1_greaterthan_person2);

        Console.Read();
        }
    }

