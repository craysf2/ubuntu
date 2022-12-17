using System;

namespace SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Split the string into an array of words at each semicolon (can be any char)
            string[] words = input.Split(';');

            // Iterate over the words and output each one on a new line
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}