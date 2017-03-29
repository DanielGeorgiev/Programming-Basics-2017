using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int f0 = 1;
        int f1 = 1;

        if (n<2)
        {
            Console.WriteLine(f0);
        }
        else
        {
            for (int i = 0; i <= n+1; i++)
            {
                sum = i + i + 1;
            }
            Console.WriteLine(sum);
        }
    }
}

