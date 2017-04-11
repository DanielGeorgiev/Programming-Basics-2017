using System;
class Program
{
    static void Main()
    {
        uint v = uint.Parse(Console.ReadLine());
        uint p1 = uint.Parse(Console.ReadLine());
        uint p2 = uint.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double x = p1 * h + p2 * h;
        double percentageFull = Math.Truncate(x/v*100);
        double percentageP1 = Math.Truncate((p1*h/x)*100);
        double percentageP2 = Math.Truncate((p2*h/x)*100);


        if (x<=v)
        {
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",percentageFull,percentageP1,percentageP2);
        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.",h,x-v);
        }
    }
}

