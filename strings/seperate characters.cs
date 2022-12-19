using System;

namespace SeparateCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Separate the characters in the string
            foreach (char c in input)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
    }
}