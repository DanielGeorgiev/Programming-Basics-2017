using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int total = 0;
        int biggestNumber = 0;

        for (int i = 1; i <= n; i++)
        {
            int numbers = int.Parse(Console.ReadLine());

            if (numbers>biggestNumber)
            {
                biggestNumber = numbers;
            }

            total += numbers;
        }
        if (total - biggestNumber == biggestNumber)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}",biggestNumber);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}",Math.Abs(biggestNumber-(total-biggestNumber)));
        }
    }
}

