using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");

            // Read user input and convert to integer
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if the weight is greater than 50 - if yes, exit the program with a message
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;  // Exit the program
            }

            // Prompt user for package width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Prompt user for package height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Prompt user for package length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Check if the sum of dimensions exceeds 50, if yes, exit program with message
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;  // Exit the program
            }

            // Calculate the shipping quote using given formula
            double quote = ((width * height * length) * weight) / 100.0;

            // Display the quote formatted as a currency amount
            Console.WriteLine("Your estimated total for shipping this package is: ${0:F2}", quote);

            // Thank the user
            Console.WriteLine("Thank you!");

            // Pause the console so user can see output before closing
            Console.ReadLine();
        }
    }
}
