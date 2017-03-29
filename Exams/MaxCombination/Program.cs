using System;
class Program
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine()); // 69
        int end = int.Parse(Console.ReadLine()); // 71
        int maxCombs = int.Parse(Console.ReadLine()); // 100
        int endUpdate = start; // 69
        int endUpdate2 = start; // 69
        



        for (int i = 0; i < maxCombs; i++)
        {
            Console.Write("<{0}-{1}>", start , endUpdate);
            endUpdate++;
            if (endUpdate > end)
            {
                start++;
                endUpdate = endUpdate2;
            }
            if (start>end)
            {
                break;
            }
        }
    }
}

