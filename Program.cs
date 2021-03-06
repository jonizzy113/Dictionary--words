﻿using System;
using System.Collections.Generic;


namespace Dictionary_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            /
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");

            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */

            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Hi", "a greeting");
            wordsAndDefinitions.Add("bye", "telling someone your leaving");
            wordsAndDefinitions.Add("happy", "meaning very Joyous");

            Console.WriteLine(wordsAndDefinitions["Hi"]);
            Console.WriteLine(wordsAndDefinitions["bye"]);

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }










            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
            }
        }
    }
}
