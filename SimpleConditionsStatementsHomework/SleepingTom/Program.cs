using System;
class Program
{
    static void Main()
    {
        double amount = double.Parse(Console.ReadLine());

        string inputMetric = Console.ReadLine();

        string outputMetric = Console.ReadLine();

        switch (inputMetric)
        {
            case "mm":
                amount = amount / 1000;
                break;
            case"cm":
                amount = amount / 100;
                break;
            case "mi":
                amount = amount / 0.000621371192;
                break;
            case "in":
                amount = amount / 39.3700787;
                break;
            case "km":
                amount = amount / 0.001;
                break;
            case "ft":
                amount = amount / 3.2808399;
                break;
            case "yd":
                amount = amount / 1.0936133;
                break;
            default:
                Console.WriteLine("Invalid metric");
                break;   
        }
        switch (outputMetric)
        {
            case "mm":
                amount = amount * 1000;
                break;
            case "cm":
                amount = amount * 100;
                break;
            case "mi":
                amount = amount * 0.000621371192;
                break;
            case "in":
                amount = amount * 39.3700787;
                break;
            case "km":
                amount = amount * 0.001;
                break;
            case "ft":
                amount = amount * 3.2808399;
                break;
            case "yd":
                amount = amount * 1.0936133;
                break;
            default:
                Console.WriteLine("Invalid metric");
                break;
        }
        Console.WriteLine("{0} {1}",amount,outputMetric);
    }
}

