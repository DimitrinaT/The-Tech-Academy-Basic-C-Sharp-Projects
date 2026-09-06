using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays the welcome message to the user.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Asks the user to enter the package weight.
            Console.WriteLine("Please enter the package weight:");

            // Converts the user's input from a string to an integer.
            int weight = Convert.ToInt32(Console.ReadLine());

            // Checks if the package weight is greater than 50.
            if (weight > 50)
            {
                // Displays an error message if the package is too heavy.
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // Asks the user to enter the package width.
                Console.WriteLine("Please enter the package width:");

                // Converts the user's input to an integer.
                int width = Convert.ToInt32(Console.ReadLine());

                // Asks the user to enter the package height.
                Console.WriteLine("Please enter the package height:");

                // Converts the user's input to an integer.
                int height = Convert.ToInt32(Console.ReadLine());

                // Asks the user to enter the package length.
                Console.WriteLine("Please enter the package length:");

                // Converts the user's input to an integer.
                int length = Convert.ToInt32(Console.ReadLine());

                // Adds the width, height, and length together.
                int totalDimensions = width + height + length;

                // Checks if the total dimensions are greater than 50.
                if (totalDimensions > 50)
                {
                    // Displays an error message if the package is too large.
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    // Multiplies the height, width, and length together.
                    int volume = height * width * length;

                    // Multiplies the volume by the package weight.
                    int shippingCalculation = volume * weight;

                    // Divides the result by 100 to calculate the shipping quote.
                    int quote = shippingCalculation / 100;

                    // Displays the shipping quote with two decimal places.
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

                    // Displays the thank-you message.
                    Console.WriteLine("Thank you!");
                }
            }

            
            Console.ReadLine();
        }
    }
}
