using System;
class Program
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        string dayOrNight = Console.ReadLine();


        if (n<20 && dayOrNight=="day")
        {
            double result = 0.70 + n * 0.79;
            Console.WriteLine(result);
        }
        else if (n<20 && dayOrNight=="night")
        {
            double result = 0.70 + n * 0.90;
            Console.WriteLine(result);
        }
        else if (n>=20 && n<=99 && dayOrNight=="day")
        {
            double result = n * 0.09;
            Console.WriteLine(result);
        }
        else if (n>=20 && n<=99 && dayOrNight=="night")
        {
            double result = n * 0.09;
            Console.WriteLine(result);
        }
        else if (n>=100 && dayOrNight=="day")
        {
            double result = n * 0.06;
            Console.WriteLine(result);
        }
        else if (n>=100 && dayOrNight=="night")
        {
            double result = n * 0.06;
            Console.WriteLine(result);
        }
    }
}

