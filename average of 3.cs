using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers: ");

        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine()); 
        double c = Convert.ToDouble(Console.ReadLine()); 
        double average = (a + b + c) / 3; 
        Console.WriteLine("Average: " + average);
    }
}
