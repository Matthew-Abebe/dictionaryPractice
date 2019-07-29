using System;
using System.Collections.Generic;


namespace dictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#.");
            wordsAndDefinitions.Add("Happy", "The feeling of students after finishing their capstones.");
            wordsAndDefinitions.Add("Nervous", "The feeling of students on the first day of school.");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            Console.WriteLine(wordsAndDefinitions["Awesome"]); // These are keys that gives you values.
            Console.WriteLine(wordsAndDefinitions["Happy"]); // These are keys that gives you values.
            Console.WriteLine(wordsAndDefinitions["Nervous"]); // These are keys that gives you values.

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */

            // This foreach loop goes over the dictionary 'wordsAndDefinitions' The KeyValuePair are both strings

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions) {
            Console.WriteLine($"The definition of {word.Key} is {word.Value}");

            }

        }
    }
}
