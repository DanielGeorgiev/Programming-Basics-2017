using System;
class Program
{
    static void Main()
    {
        double value = double.Parse(Console.ReadLine());
        string inputUnit = Console.ReadLine();
        string outputUnit = Console.ReadLine();
        double meter = 1;
        double millimeter = 1000;
        double centimeter = 100;
        double mile = 0.000621371192;
        double inch = 39.3700787;
        double kilometer = 0.001;
        double feet = 3.2808399;
        double yard = 1.0936133;


        switch (inputUnit)
        {
            case "m":
                Console.WriteLine();
                break;
            default:
                break;
        }
    }
}

