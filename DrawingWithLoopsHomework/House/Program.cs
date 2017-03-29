using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int evenStars = 2;
        int oddStars = 1;
        int evenDashes = (n - 2) / 2;
        int oddDashes = (n - 1) / 2;


        for (int i = 0; i < (n+1)/2; i++)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("{0}{1}{2}", new string('-', evenDashes), new string('*', evenStars), new string('-', evenDashes));
            }

            else
            {
                Console.WriteLine("{0}{1}{2}", new string('-', oddDashes), new string('*',oddStars), new string('-', oddDashes));
            }

            evenStars += 2;
            oddStars += 2;
            evenDashes -= 1;
            oddDashes -= 1;
        }


        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("|{0}|", new string('*',n-2));
        }
    }
}

