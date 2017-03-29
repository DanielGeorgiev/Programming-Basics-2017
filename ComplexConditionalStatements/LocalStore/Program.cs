using System;
class Program
{
    static void Main()
    {
        string product = Console.ReadLine();
        string city = Console.ReadLine();

        decimal quantity = decimal.Parse(Console.ReadLine());

        decimal price = 0;

        if (city == "Sofia")
        {
            if (product=="coffee")
            {
                price += 0.50m;
            }
            else if (product=="water")
            {
                price += 0.80m;
            }
            else if (product=="beer")
            {
                price += 1.20m;
            }
            else if (product=="sweets")
            {
                price += 1.45m;
            }
            else if (product=="peanuts")
            {
                price += 1.60m;
            }
        }


        if (city == "Plovdiv")
        {
            if (product == "coffee")
            {
                price += 0.40m;
            }
            else if (product == "water")
            {
                price += 0.70m;
            }
            else if (product == "beer")
            {
                price += 1.15m;
            }
            else if (product == "sweets")
            {
                price += 1.30m;
            }
            else if (product == "peanuts")
            {
                price += 1.50m;
            }
        }

        if (city == "Varna")
        {
            if (product == "coffee")
            {
                price += 0.45m;
            }
            else if (product == "water")
            {
                price += 0.70m;
            }
            else if (product == "beer")
            {
                price += 1.10m;
            }
            else if (product == "sweets")
            {
                price += 1.35m;
            }
            else if (product == "peanuts")
            {
                price += 1.55m;
            }
        }
        Console.WriteLine(price*quantity);
    }
}

