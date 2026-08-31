using System;


namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the name of the college
            Console.WriteLine("Academy of Learning Career College");
            // Display the title of the student daily report
            Console.WriteLine("Student Daily Report");
            // Ask the student for their name and store the answer in the name variable
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            // Ask the student which course they are currently taking 
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            // Ask for the current page number
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            // Ask if the student needs help
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            // Store the answer as a string
            string needHelp = Console.ReadLine();
            // Store the answer as a string
            bool needHelpBool = bool.Parse(needHelp);
            // Ask about positive experiences
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            // Store the student's response
            string positiveExperiences = Console.ReadLine();
            // Ask for additional feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please give specific.");
            // Store the student's feedback
            string feedback = Console.ReadLine();
            // Ask how many hours the student studied
            Console.WriteLine("How many hours did you study today?");
            // Store the number of study hours as a string
            string studyHours = Console.ReadLine();
            // Convert the study hours to an integer
            int studyHoursNum = Convert.ToInt32(studyHours);
            // Thank the student for completing the report
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            // Keep the console window open
            Console.ReadLine();
        }
    }
}
