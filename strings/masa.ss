static void Main(string[] args)
{
    Console.Write("Enter a string: ");
    string input = Console.ReadLine();

    string reverse = string.Empty;

    for (int i = input.Length - 1; i >= 0; i--)
    {
        reverse += input[i];
    }

    Console.WriteLine("The reversed string is: " + reverse);
}
