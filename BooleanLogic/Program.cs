using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the title of the application
            Console.WriteLine("Car Insurance Application"); 
            
            // Ask the application for there aga
            Console.WriteLine("What is your age?");

            // Read the applicant's age from the keyboard and convert it from a string to an integer
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask the applicant if they have ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");

            // Read the applicant's answer and convert it to lowercase
            string answer = Console.ReadLine().ToLower();

            // Check if the applicant answered "yes"
            // If they answered "yes", dui will be true
            // If they answered "no", dui will be false.
            bool dui = answer == "yes";

            // Ask the applicant how many speeding tickets they have
            Console.WriteLine("How many speeding tickets do you have?");

            // Read the number of speeding tickets and convert it from a string to an integer
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Ask the applicant if they qualify for car insurance
            Console.WriteLine("Qualified for insurance?");

            // Check all the insurance requirements and store the result as true or false
            // The applicant must be over 15, must not have a DUI, and must have no more than 3 speeding tickets
            bool qualified = (age > 15) && !dui && (tickets <= 3);

            // Display the result of the Boolean expression.
            Console.WriteLine(qualified);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
