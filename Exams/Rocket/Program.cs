using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int points = (n * 3 - 2) / 2;
        int spaces = 0;
        int newPoints = 0;
        int newSpaces = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}/{1}\\{0}", new string('.',points), new string(' ',spaces));
            points--;
            spaces += 2;
            newPoints = points+1;
            newSpaces = spaces-2;
        }

        Console.WriteLine("{0}{1}{0}", new string('.', newPoints), new string('*', n * 2));

        for (int i = 0; i < n*2; i++)
        {
            Console.WriteLine("{0}|{1}|{0}", new string('.', newPoints), new string('\\',newSpaces));
        }
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}/{1}\\{0}", new string('.',newPoints), new string('*',newSpaces));
            newSpaces+=2;
            newPoints--;
        }
    }
}

