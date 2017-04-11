using System;
class Program
{
    static void Main()
    {
        Console.Write("Degrees in Celsius: ");
        double celcius = double.Parse(Console.ReadLine());
        double toFahrenhait = celcius * 1.8000 + 32.00;
        Console.WriteLine("In Fahrenhait: " +Math.Round(toFahrenhait,2));
    }
}

