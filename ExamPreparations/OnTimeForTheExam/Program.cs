using System;
class Program
{
    static void Main()
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinute = int.Parse(Console.ReadLine());
        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinute = int.Parse(Console.ReadLine());

        int examMinutes = examHour * 60 + examMinute;
        int arrivalMinutes = arrivalHour * 60 + arrivalMinute;

        if (examMinutes == arrivalMinutes)
        {
            Console.WriteLine("On time");
        }

        else if (examMinutes - arrivalMinutes > 0 && examMinutes - arrivalMinutes <= 30)
        {
            Console.WriteLine("On time");
            Console.WriteLine("{0} minutes before the start", examMinutes-arrivalMinutes);
        }

        else if (arrivalMinutes - examMinutes > 0 && arrivalMinutes - examMinutes < 60)
        {
            Console.WriteLine("Late");
            Console.WriteLine("{0} minutes after the start", arrivalMinutes-examMinutes);
        }

        else if (arrivalMinutes - examMinutes >= 60)
        {
            Console.WriteLine("Late");
            if ( (arrivalMinutes-examMinutes) % 60 < 10 )
            {
                Console.WriteLine("{0}:0{1} hours after the start", (arrivalMinutes - examMinutes) / 60, (arrivalMinutes - examMinutes) % 60);
            }
            else
            {
                Console.WriteLine("{0}:{1} hours after the start", (arrivalMinutes - examMinutes) / 60, (arrivalMinutes - examMinutes) % 60);
            }
        }

        else if (examMinutes-arrivalMinutes > 0 && examMinutes - arrivalMinutes < 60)
        {
            Console.WriteLine("Early");
            Console.WriteLine("{0} minutes before the start", examMinutes-arrivalMinutes);
        }

        else if (examMinutes - arrivalMinutes >= 60)
        {
            Console.WriteLine("Early");
            if ((examMinutes - arrivalMinutes) % 60 < 10)
            {
                Console.WriteLine("{0}:0{1} hours before the start", (examMinutes - arrivalMinutes) / 60, (examMinutes - arrivalMinutes) % 60);
            }
            else
            {
                Console.WriteLine("{0}:{1} hours before the start", (examMinutes - arrivalMinutes) / 60, (examMinutes - arrivalMinutes) % 60);
            }
        }
    }
}
            