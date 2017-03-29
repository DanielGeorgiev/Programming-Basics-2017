using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dashes = 2 * n - 1;
        int stars = 1;
        int updateStars = n / 2;
        int updateStars2 = n;
        int updateDashes = 1;
        int updateStars3 = n * 2 - 1;


        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('*', stars), new string('-', dashes), new string('*', stars));
            dashes -= 2;
            stars += 1;
        }

        for (int i = 0; i < n / 3; i++)
        {
            Console.WriteLine("|{0}\\{1}/{0}|", new string('*', updateStars), new string('*', updateStars2));
            updateStars++;
            updateStars2 -= 2;
        }

        for (int i = n; i > 0; i--)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('-', updateDashes), new string('*', updateStars3));
            updateStars3 -= 2;
            updateDashes++;
        }
    }
}


