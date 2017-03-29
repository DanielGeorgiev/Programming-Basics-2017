using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int b = n;

        for (int i = 1; i < n; i++)
        {
            b = b * i;
        }
        Console.WriteLine(b);
    }
}

