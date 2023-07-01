using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        //Get package weight
        Console.WriteLine("Enter the package weight: ");
        int package_weight = Convert.ToInt32(Console.ReadLine());

        //Make sure package weight is less than 50
        if (package_weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.Read();
        }
        else
        {
            //Get package dimensions
            Console.WriteLine("Enter package width: ");
            float package_width = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter package height: ");
            float package_height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter package length: ");
            float package_length = Convert.ToSingle(Console.ReadLine());

            //Make sure sum of dimensions is less than 50
            double package_sum_dimensions = package_width + package_height + package_length;
            if (package_sum_dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.Read();
            }
            else
            {
                //Calculate and display quote
                double package_quote = package_width * package_length * package_height * package_weight / 100.00;
                Console.WriteLine("Your estimated total for shipping this package is: $" + Math.Round(package_quote, 2, MidpointRounding.AwayFromZero).ToString("0.00"));


                Console.Read();
            }
        }
    }
}
