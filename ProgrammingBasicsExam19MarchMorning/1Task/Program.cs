using System;
class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double stranichnaStrana = x * y;
        double window = 1.5 * 1.5;
        double sumStranichna = stranichnaStrana * 2 - 2 * window;

        double zadnaStrana = x * x;
        double vhod = 1.2 * 2;
        double sumPrednaZadna = 2 * (x * x) - vhod;

        double sum = sumStranichna + sumPrednaZadna;
        double zelenaBoq = sum / 3.4;

        double pokriv1 = 2 * (x * y);
        double pokriv2 = 2 * ((x * h) / 2);
        double ChervenaBoq = (pokriv1 + pokriv2) / 4.3;
        Console.WriteLine("{0:f2}", zelenaBoq);
        Console.WriteLine("{0:f2}", ChervenaBoq);
    }
}
