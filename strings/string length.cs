using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    Console.WriteLine("enter a string: ");
	string input = Console.ReadLine();
	
	int counter = 0;
	
	foreach (char n in input)
	{
		counter++;
	}
	
Console.WriteLine("length is: {0}", counter);
    }
}