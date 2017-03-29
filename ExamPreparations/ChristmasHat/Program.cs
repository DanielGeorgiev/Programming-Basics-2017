using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int points = 2 * n - 1;
        int dashes = 0;


        Console.WriteLine("{0}/|\\{1}", new string('.',n*2-1), new string('.',n*2-1));
        Console.WriteLine("{0}\\|/{1}", new string('.', n * 2 - 1), new string('.', n * 2 - 1));

        for (int i = 1; i <= 2*n; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.',points), new string('-',dashes));
            points--;
            dashes++;
        }

        Console.WriteLine(new string('*',4*n+1));

        for (int i = 1; i <= 2*n ; i++)
        {
            Console.Write("*.");
        }

        Console.WriteLine("*");

        Console.WriteLine(new string('*',4*n+1));
    }
}

