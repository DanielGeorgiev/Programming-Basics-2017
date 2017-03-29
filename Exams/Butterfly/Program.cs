using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}\\ /{0}", new string('*',n-2));

        for (int i = 0; i < (n-2)/2; i++)
        {
            Console.WriteLine("{0}\\ /{0}", new string('-',n-2));
            Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
        }
        Console.WriteLine("{0}@", new string(' ',n-1));

        for (int i = (n-2)/2; i > 0; i--)
        {
            Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
            Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
        }
        Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
    }
}

