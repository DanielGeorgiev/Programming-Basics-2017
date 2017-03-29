using System;
class Program
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine()); // 10
        int end = int.Parse(Console.ReadLine()); // 1
        int magicNumber = int.Parse(Console.ReadLine()); // 5
        int newEnd = start;
        int newStart = start;
        int count = 1;
        for (int i = end; i <= start; i++)
        {
            for (int j = end; j <= start; j++)
            {
                Console.WriteLine("{0} {1} ", newStart, newEnd);
                newEnd--;
                if (newEnd < end)
                {
                    newStart--;
                    newEnd = start;
                }
                if (newStart + newEnd == magicNumber)
                {
                    Console.WriteLine("Combination N:{0}", count);
                    Console.WriteLine("{0} + {1} = {2}", newStart, newEnd, newStart + newEnd);
                    return;
                }
            }
        }
    }
}
