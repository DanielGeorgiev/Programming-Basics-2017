using System;
class Program
{
    static void Main()
    {
        uint v = uint.Parse(Console.ReadLine());
        uint p1 = uint.Parse(Console.ReadLine());
        uint p2 = uint.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double fullP1 = p1 * h;
        double fullP2 = p2 * h;

        if (fullP1+fullP2 <= v)
        {
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(((fullP1 + fullP2) / v) * 100), Math.Truncate((fullP1 / (fullP1 + fullP2)) * 100), Math.Truncate((fullP2 / (fullP1 + fullP2)) * 100));
        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, (fullP1 + fullP2) - v);
        }
    }
}

