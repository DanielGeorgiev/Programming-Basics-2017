using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int numberUpdate = n;

        for (int i = 0; i < (n % 100 / 10) + (n / 100); i++)
        {
            for (int j = 0; j < (n / 100) + (n % 100 % 10); j++)
            {
                if (numberUpdate % 5 == 0)
                {
                    numberUpdate = numberUpdate - (n / 100);
                }
                else if (numberUpdate % 3 == 0 )
                {
                    numberUpdate = numberUpdate - (n % 100 / 10);
                }
                else if (numberUpdate % 3 != 0 && numberUpdate % 5 != 0)
                {
                    numberUpdate = numberUpdate + (n % 100 % 10);
                }
                Console.Write("{0} ",numberUpdate);
            }
            Console.WriteLine();
        }
    }
}
