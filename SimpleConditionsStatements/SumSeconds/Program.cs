using System;
class Program
{
    static void Main()
    {
        int firstCompetitorSeconds = int.Parse(Console.ReadLine());
        int secondCompetitorSeconds = int.Parse(Console.ReadLine());
        int thirdCompetitorSeconds = int.Parse(Console.ReadLine());
        int totalSeconds = firstCompetitorSeconds + secondCompetitorSeconds + thirdCompetitorSeconds;
        int minutes = 0;


        if (totalSeconds<59)
        {
            minutes += 0;
            totalSeconds = firstCompetitorSeconds + secondCompetitorSeconds + thirdCompetitorSeconds;
        }
        else if (totalSeconds>=60 && totalSeconds<=119)
        {
            minutes += 1;
            totalSeconds = (firstCompetitorSeconds + secondCompetitorSeconds + thirdCompetitorSeconds) - 60;
        }
        else if (totalSeconds>=120 && totalSeconds<179)
        {
            minutes += 2;
            totalSeconds = (firstCompetitorSeconds + secondCompetitorSeconds + thirdCompetitorSeconds) - 120;
        }


        if (totalSeconds<10)
        {
            Console.WriteLine("{0}:0{1}",minutes,totalSeconds);
        }
        else
        {
            Console.WriteLine("{0}:{1}",minutes,totalSeconds);
        }
    }
}

