using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy.");
        Console.WriteLine("Student Daily Report.");

        //Ask user for name
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();

        //Ask what course user is on
        Console.WriteLine("What course are you on?");
        string userCourseNumber = Console.ReadLine();


        //Ask course page #
        Console.WriteLine("What page number?");
        string userCoursePageString = Console.ReadLine();
        int userCoursePage = Convert.ToInt32(userCoursePageString);

        //Ask if need help
        Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
        string userNeedHelpString = Console.ReadLine();
        bool userNeedHelp = Convert.ToBoolean(userNeedHelpString);

        //Ask positive experiences
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string userPositiveExperiences = Console.ReadLine();

        //Ask feedback
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string userFeedback = Console.ReadLine();

        //Ask hours studied
        Console.WriteLine("How many hours did you study today?");
        string userHoursString = Console.ReadLine();
        int userHours = Convert.ToInt32(userHoursString);


        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.Read();

    }
}
