using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int wordCount = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine("Word Count: " + wordCount);
    }
}