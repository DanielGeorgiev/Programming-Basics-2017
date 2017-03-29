using System;
class Program
{
    static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string place = "";
        string location = "";
        decimal newBudget = 0;

        if (budget<=1000)
        {
            place = "Camp";
            if (season == "Summer")
            {
                location = "Alaska";
                newBudget = budget * 65 / 100;
            }
            else if (season == "Winter")
            {
                location = "Morocco";
                newBudget = budget * 45 / 100;
            }
        }
        else if (budget>1000 && budget<=3000)
        {
            place = "Hut";
            if (season == "Summer")
            {
                location = "Alaska";
                newBudget = budget * 80 / 100;
            }
            else if (season == "Winter")
            {
                location = "Morocco";
                newBudget = budget * 60 / 100;
            }
        }

        else if (budget>3000)
        {
            place = "Hotel";
            newBudget = budget * 90 / 100;
            if (season == "Summer")
            {
                location = "Alaska";
            }
            else if (season == "Winter")
            {
                location = "Morocco";
            }
        }

        Console.WriteLine("{0} - {1} - {2:f2}", location, place , newBudget);
    }
}

