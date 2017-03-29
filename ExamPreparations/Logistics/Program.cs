using System;
class Program
{
    static void Main()
    {
        double load = double.Parse(Console.ReadLine());
        double loadKgSum = 0;
        double microbus = 0;
        double tir = 0;
        double train = 0;

        for (int i = 0; i < load; i++)
        {
            int loadKg = int.Parse(Console.ReadLine());
            loadKgSum += loadKg;

            if (loadKg < 4)
            {
                microbus+=loadKg; 
            }
            if (loadKg >= 4 && loadKg < 12)
            {
                tir+=loadKg;
            }
            if (loadKg >= 12)
            {
                train+=loadKg;
            }
        }

        Console.WriteLine("{0:f2}", ((microbus * 200) + (tir * 175) + (train * 120)) / loadKgSum);
        Console.WriteLine("{0:f2}%", microbus / loadKgSum * 100);
        Console.WriteLine("{0:f2}%", tir / loadKgSum * 100);
        Console.WriteLine("{0:f2}%", train / loadKgSum * 100);
    }
}

