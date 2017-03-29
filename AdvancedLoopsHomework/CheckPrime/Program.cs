using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (n < 2)
        {
            isPrime = false;
        }

        else
        {
            for (int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime == true)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }

    }
}

