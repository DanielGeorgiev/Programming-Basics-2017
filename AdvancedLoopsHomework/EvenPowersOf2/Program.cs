using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("1");
        for (int i = 1; i <= n; i++)
        {
            if (i%2 == 0)
            {
                Console.WriteLine(Math.Pow(2,i));
            }
        }
    }
}

