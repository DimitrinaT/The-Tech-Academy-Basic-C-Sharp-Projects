using System;


namespace Math_and_Comparison_Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays the title of the program
            Console.WriteLine("Anonymous Income Comparison Program");

            // Displays a heading for Person 1
            Console.WriteLine("Person 1");

            // Asks the user to enter Person 1's hourly rate
            Console.WriteLine("Hourly rate?");

            // Reads the hourly rate 
            string hourlyRate1 = Console.ReadLine();

            // Asks the user to enter Person 1's hours worked per week
            Console.WriteLine("Hours worked per week?");

            // Reads the hours worked per week
            string hours1 = Console.ReadLine();

            // Calculates Person 1's annual salary
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;

            // Asks the user to enter Person 2's hourly rate
            Console.WriteLine("Person 2");

            // Reads the hourly rate entered by the user
            Console.WriteLine("Hourly rate?");

            // Asks the user to enter Person 2's hours worked per week
            string hourlyRate2 = Console.ReadLine();

            // Reads the hours worked per week
            Console.WriteLine("Hours worked per week?");

            // Reads the hours worked per week
            string hours2 = Console.ReadLine();

            // Calculates Person 2's annual salary
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;

            // Displays Person 1's annual salary
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);

            // Displays Person 2's annual salary
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);

            // Displays the comparison question
            Console.WriteLine("Does Person 1 make more money than Person 2?");

            // Compares the two salaries and stores the result as true or false
            bool isMore = salary1 > salary2;

            // Displays the true or false result
            Console.WriteLine(isMore);
            Console.ReadLine();
        }
    }
}
