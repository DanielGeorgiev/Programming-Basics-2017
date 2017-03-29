using System;
class Program
{
    static void Main()
    {
        decimal balance = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        decimal newBalance = 0;
        string holiday = "";
        string destination = "";

        if (balance <= 100)
        {
            destination = "Bulgaria";
            if (season == "summer")
            {
                holiday = "Camp";
                newBalance = balance * 0.30m;
            }
            else if (season == "winter")
            {
                holiday = "Hotel";
                newBalance = balance * 0.70m;
            }
        }

        if (balance > 100 && balance <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                holiday = "Camp";
                newBalance = balance * 0.40m;
            }
            else if (season == "winter")
            {
                holiday = "Hotel";
                newBalance = balance * 0.80m;
            }
        }

        if (balance > 1000)
        {
            destination = "Europe";
            if (season == "summer" || season == "winter")
            {
                holiday = "Hotel";
                newBalance = balance * 0.90m;
            }
        }

        Console.WriteLine("Somewhere in " + destination);
        Console.WriteLine(holiday + " - {0:f2} ", newBalance);
    }
}

