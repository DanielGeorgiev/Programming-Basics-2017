using System;
class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double dividedBy2 = 0;
        double dividedBy3 = 0;
        double dividedBy4 = 0;

        for (int i = 0; i < n; i++)
        {
            int count = int.Parse(Console.ReadLine());

            if (count % 2 == 0)
            {
                dividedBy2++;
            }
            if (count % 3 == 0)
            {
                dividedBy3++;
            }
            if (count % 4 == 0)
            {
                dividedBy4++;
            }
        }

        Console.WriteLine("{0:f2}%",dividedBy2/n*100);
        Console.WriteLine("{0:f2}%",dividedBy3/n*100);
        Console.WriteLine("{0:f2}%",dividedBy4/n*100);
    }
}

