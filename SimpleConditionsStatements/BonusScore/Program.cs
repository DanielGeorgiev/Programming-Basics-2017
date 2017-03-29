using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter Score: ");
        double num = double.Parse(Console.ReadLine());
        double bonus = 0;

        if (num<=100)
        {
            bonus += 5;
        }
        else if (num>=1000)
        {
            bonus = num * 10 / 100;
        }
        else if (num>100)
        {
            bonus = num * 20 / 100;
        }
        if (num%2==0)
        {
            bonus += 1;
        }
        else if (num%10==5)
        {
            bonus += 2;
        }
        Console.WriteLine("Bonus score: {0}",bonus);
        Console.WriteLine("Total score: {0}",num+bonus);
        //Additional bonus points
    }
}

