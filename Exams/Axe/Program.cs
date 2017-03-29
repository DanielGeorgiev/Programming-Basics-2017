using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int spaces = 0;
        int rightDashes = n * 2 - 2;
        int leftDashes = n * 3;
        int newSpaces = n-1;
        int newDashes = n-1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-',spaces), new string('-',rightDashes));
            rightDashes--;
            spaces++;
        }

        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('*', leftDashes), new string('-', newSpaces), new string('-', newDashes));
        }

        for (int i = 0; i < n/2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', newSpaces), new string('-', newDashes));
            newSpaces += 2;
            leftDashes--;
            newDashes--;
        }

        Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('*', newSpaces), new string('-', newDashes));

    }
}

