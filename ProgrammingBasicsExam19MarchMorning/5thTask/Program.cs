using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int points = 1;
        int klyomba = 2*n-5;
        int spaces = 0;


        Console.WriteLine(new string('*',2*n+1));
        Console.WriteLine("{0}*{1}*{0}", new string('.',points), new string(' ',2*n-3));
        points = 2;
        for (int i = 0; i < n-2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', points), new string('@', klyomba));
            points++;
            klyomba -= 2;
        }

        Console.WriteLine("{0}*{0}", new string('.',n));

        for (int i = 0; i < n-2; i++)
        {
            Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', points-1), new string(' ',spaces));
            spaces++;
            points--;
        }
        Console.WriteLine(".*{0}*.", new string('@',2*n-3));
        Console.WriteLine(new string('*',2*n+1));
    }
}

