using System;
class Program
{
    static void Main()
    {
        double magnoliiPrice = 3.25;
        double zumbuliPrice = 4;
        double roziPrice = 3.50;
        double kaktusiPrice = 8;

        double broiMagnolii = double.Parse(Console.ReadLine());
        double broiZumbuli = double.Parse(Console.ReadLine());
        double broiRozi = double.Parse(Console.ReadLine());
        double broiKaktusi = double.Parse(Console.ReadLine());
        
        double presentPrice = double.Parse(Console.ReadLine());

        double sum = (double)magnoliiPrice * broiMagnolii + zumbuliPrice * broiZumbuli + roziPrice * broiRozi + kaktusiPrice * broiKaktusi - (magnoliiPrice * broiMagnolii + zumbuliPrice * broiZumbuli + roziPrice * broiRozi + kaktusiPrice * broiKaktusi) * 5.0 / 100.0;

        if (sum >= presentPrice)
        {
            Console.WriteLine("She is left with {0} leva.", Math.Floor(sum-presentPrice));
        }

        else
        {
            Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(presentPrice-sum));
        }
    }
}

