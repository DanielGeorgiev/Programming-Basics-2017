using System;
class Program
{
    static void Main()
    {
        double w = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double hInCm = h * 100.00 - 100.00;
        double wInCm = w * 100.00;

        double officesOnRow = Math.Truncate(hInCm / 70.00);
        double rows = Math.Truncate(wInCm / 120.00);

        Console.WriteLine(officesOnRow);
        Console.WriteLine(rows);
        Console.WriteLine(officesOnRow*rows-3);
    }
}
