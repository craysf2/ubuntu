using System;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            
            int counter = 1; // 1 because first word

            for (int i = 0; i < input.Length; i++) //instead of this we can also use .split() function
            {
                if (input[i] == ' ')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}