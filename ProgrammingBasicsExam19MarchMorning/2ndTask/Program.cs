using System;
class Program
{
    static void Main()
    {
        double cupsAmount = double.Parse(Console.ReadLine());
        double workers = double.Parse(Console.ReadLine());
        double workDays = double.Parse(Console.ReadLine());

        double sumWorkHours = workers * workDays * 8;
        double cupsCreated = Math.Floor(sumWorkHours / 5);

        if (cupsAmount>=cupsCreated)
        {
            Console.WriteLine("Losses: {0:f2}",(cupsAmount-cupsCreated)*4.2);
        }
        else
        {
            Console.WriteLine("{0:f2} extra money",(cupsCreated-cupsAmount)*4.2);
        }
    }
}

