using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;

        Console.WriteLine(num);
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(num *= 4);
        }
    }
}