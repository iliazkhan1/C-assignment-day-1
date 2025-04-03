using System;
class Program
{
    static void Main()
    {
        TimeZoneInfo localZone = TimeZoneInfo.Local;
        Console.WriteLine("Time Zone: " + localZone.StandardName);
        Console.WriteLine("Current Time Zone: " + localZone.DisplayName);

    }
}

