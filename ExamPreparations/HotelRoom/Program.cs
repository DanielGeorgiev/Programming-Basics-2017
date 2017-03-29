using System;
class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        double nights = double.Parse(Console.ReadLine());
        double studio = 0;
        double apartament = 0;

        if (month == "May" || month == "October")
        {
            studio = 50 * nights;
            apartament = 65 * nights;
            if (nights>7 && nights<15)
            {
                studio -= studio * 5 / 100; 
            }
            else if (nights>13)
            {
                studio -= studio * 30 / 100;
            }
            if (nights > 14)
            {
                apartament -= apartament * 10 / 100;
            }
        }
        else if (month == "June" || month == "September")
        {
            studio = 75.20 * nights;
            apartament = 68.70 * nights;
            if (nights>14)
            {
                studio -= studio * 20 / 100;
            }
            if (nights>14)
            {
                apartament -= apartament * 10 / 100;
            }
        }
        else if (month == "July" || month == "August")
        {
            studio = 76 * nights;
            apartament = 77 * nights;
            if (nights > 14)
            {
                apartament -= apartament * 10 / 100;
            }
        }
        Console.WriteLine("Apartment: {0:f2} lv.", apartament);
        Console.WriteLine("Studio: {0:f2} lv.",studio);
    }
}

