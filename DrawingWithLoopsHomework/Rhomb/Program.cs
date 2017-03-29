using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            Console.Write(new string (' ',n-row));
            Console.Write("*");
            for (int stars = 1; stars <= row-1; stars++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }

        for (int i = n-1; i >= 1; i--)
        {
            Console.Write(new string(' ',n-i));
            for (int stars = 1; stars <= i ; stars++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
}


