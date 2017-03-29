using System;
class Program
{
    static void Main()
    {
        int km = int.Parse(Console.ReadLine());
        string dayOrNight = Console.ReadLine();

        if (km<20)
        {
            if (dayOrNight == "day")
            {
                Console.WriteLine(0.70+(km*0.79)); 
            }
            else if (dayOrNight == "night")
            {
                Console.WriteLine(0.70+(km*0.90));
            }
        }

        if (km>=20 && km<100)
        {
            if (dayOrNight == "day" || dayOrNight == "night")
            {
                Console.WriteLine(km*0.09);
            }
        }

        if (km>=100)
        {
            if (dayOrNight == "day" || dayOrNight == "night")
            {
                Console.WriteLine(km*0.06);
            }
        }
    }
}

