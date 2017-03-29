using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < n; i++)
        {
            int leftNumbers = int.Parse(Console.ReadLine());
            leftSum += leftNumbers;
        }
        for (int i = 0; i < n; i++)
        {
            int rightNumbers = int.Parse(Console.ReadLine());
            rightSum += rightNumbers;
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes, sum = {0}",leftSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}",Math.Abs(leftSum-rightSum));
        }
    }
}

