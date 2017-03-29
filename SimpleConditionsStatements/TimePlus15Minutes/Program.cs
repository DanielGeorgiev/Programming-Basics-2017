using System;
class Program
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int minutesSummary = minutes + 15;


        if (minutesSummary>59 && hours==23)
        {
            hours = hours - hours;
            minutesSummary -= 60;
        }
        else if (minutesSummary>59)
        {
            hours += 1;
            minutesSummary -= 60;
        }


        if (minutesSummary<10)
        {
            Console.WriteLine("{0}:0{1}",hours,minutesSummary);
        }
        else
        {
            Console.WriteLine("{0}:{1}",hours,minutesSummary);
        }

    }
}

