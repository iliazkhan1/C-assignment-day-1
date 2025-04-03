using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        double max;
        if (a > b && a > c)
            max = a;
        else if (b > c)
            max = b;
        else
            max = c;

        Console.WriteLine("Biggest number: " + max);
    }
}
