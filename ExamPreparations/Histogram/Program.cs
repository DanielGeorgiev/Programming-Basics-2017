using System;
class Program
{
    static void Main()
    {
        double n = int.Parse(Console.ReadLine());
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        double p5 = 0;

        for (int i = 1; i <= n; i++)
        {
            int readNumber = int.Parse(Console.ReadLine());

            if (readNumber < 200)
            {
                p1++;
            }
            if (readNumber>=200 && readNumber<400)
            {
                p2++;
            }
            if (readNumber>=400 && readNumber<600)
            {
                p3++;
            }
            if (readNumber>=600 && readNumber<800)
            {
                p4++;   
            }
            if (readNumber>=800)
            {
                p5++;
            }
        }

        Console.WriteLine("{0:f2}%", p1 / n * 100);
        Console.WriteLine("{0:f2}%", p2 / n * 100);
        Console.WriteLine("{0:f2}%", p3 / n * 100);
        Console.WriteLine("{0:f2}%", p4 / n * 100);
        Console.WriteLine("{0:f2}%", p5 / n * 100);
    }
}
