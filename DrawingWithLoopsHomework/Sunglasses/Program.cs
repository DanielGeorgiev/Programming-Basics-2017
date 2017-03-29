using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{2}", new string('*', n * 2), new string(' ', n), new string('*', n * 2));
        for (int i = 0; i < n - 2; i++)
        {
            if (i == ((n-1)/2)-1)
            {
                Console.WriteLine("*{0}*{1}*{2}*", new string('/', n * 2 - 2), new string('|', n), new string('/', n * 2 - 2));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{2}*", new string('/', n * 2 - 2), new string(' ', n), new string('/', n * 2 - 2));
            }
        }
        Console.WriteLine("{0}{1}{2}", new string('*', n * 2), new string(' ', n), new string('*', n * 2));
    }
}
 
