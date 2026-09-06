using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Hello"; 
            string middleText = "my name is";
            string lastName = "Dimitrina";

            // Concatenates the three strings together to create one sentence
            string fullSentence = firstName + " " + middleText + " " + lastName;

            // Displays the concatenated string
            Console.WriteLine(fullSentence);

            // Converts the full sentence to uppercase using the ToUpper() method
            string uppercaseSentence = fullSentence.ToUpper();

            // Display the uppercase version of the sentence
            Console.WriteLine(uppercaseSentence);

            // Creates a new StringBuilder object
            StringBuilder sb = new StringBuilder();

            // Adds the first sentence to the StringBuilder
            sb.Append("Learning C# is an exciting journey. ");

            // Adds the second sentence to the StringBuilder
            sb.Append("I am learning how to work with strings. ");

            // Adds the third sentence to the StringBuilder
            sb.Append("StringBuilder is useful for creating paragraphs. ");

            // Displays the completed paragraph
            Console.WriteLine(sb);

            Console.ReadLine();

        }
    }
}
