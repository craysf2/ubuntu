using System;

namespace CountCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else if (char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    specialCharCount++;
                }
            }

            Console.WriteLine("Number of alphabets: {0}", alphabetCount);
            Console.WriteLine("Number of digits: {0}", digitCount);
            Console.WriteLine("Number of special characters: {0}", specialCharCount);
        }
    }
}