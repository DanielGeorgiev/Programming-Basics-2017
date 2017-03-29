using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int star1 = 1;
        int topEvenDashes = (n - 2) / 2;
        int topMidEvenDashes = 0;
        int bottomEvenDashes = 1;
        int bottomMidEvenDashes = n-4;

        int topOddDashes = (n - 1) / 2;
        int star2 = 0;
        int topMidOddDashes = 0;
        int bottomOddDashes = 1;
        int bottomMidOddDashes = n-4;
        int star3 = 1;

        if (n % 2 == 0)
        {
            //EVEN Top
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('_', topEvenDashes), new string('*', star1), new string('_', topMidEvenDashes), new string('*', star1), new string('_', topEvenDashes));
                topEvenDashes--;
                topMidEvenDashes += 2;
            }

            //EVEN Middle
            Console.WriteLine("*{0}*", new string('_', n - 2));

            //EVEN Bottom
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('_', bottomEvenDashes), new string('*', star1), new string('_', bottomMidEvenDashes), new string('*', star1), new string('_', bottomEvenDashes));
                bottomEvenDashes++;
                bottomMidEvenDashes -= 2;
            }
        }



        else
        {
            //ODD Top
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('_',topOddDashes), new string('*',star1), new string('_',topMidOddDashes), new string('*',star2), new string('_',topOddDashes));
                topOddDashes--;
                star2 = 1;
                if (i==0)
                {
                    topMidOddDashes = 1;
                }
                else
                {
                    topMidOddDashes += 2;
                }
            }

            //ODD Middle
            Console.WriteLine("{0}{1}{2}",new string('*',star1), new string('_',n-2), new string('*',star1));

            //ODD Bottom
            for (int j = 1; j <= (n - 1) / 2; j++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('_', bottomOddDashes), new string('*', star1), new string('_', bottomMidOddDashes), new string('*', star3), new string('_', bottomOddDashes));
                bottomOddDashes++;

                if (j == ((n-1) / 2) - 1)
                {
                    bottomMidOddDashes = 0;
                    star3--;
                }
                else
                {
                    bottomMidOddDashes -= 2;
                }
            }
        }
    }
}
