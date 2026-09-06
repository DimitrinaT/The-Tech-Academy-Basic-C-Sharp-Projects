using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            // A while loop. The code inside the loop will continue running while the condition is true
            while (number <= 5)
            {
                // Displays the current value of number.
                Console.WriteLine("While loop number: " + number);

                // Increases the value of number by 1 so the loop can eventually end.
                number++;
            }

            // Creates another integer variable to use in the do while loop.
            int secondNumber = 1;

            
            // The code inside the loop runs at least once before the condition is checked.
            do
            {
                // Displays the current value of secondNumber.
                Console.WriteLine("Do while loop number: " + secondNumber);

                // Increases the value of secondNumber by 1.
                secondNumber++;

                // Continues the loop while secondNumber is less than or equal to 5.
            } while (secondNumber <= 5);

           
            Console.ReadLine();
        }
    }
}
