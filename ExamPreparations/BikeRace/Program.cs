using System;
class Program
{
    static void Main()
    {
        double juniors = double.Parse(Console.ReadLine());
        double seniors = double.Parse(Console.ReadLine());
        string layout = Console.ReadLine();

        double sum = 0;

        if (layout == "trail")
        {
            sum = (juniors * 5.5 + seniors * 7) - (juniors * 5.5 + seniors * 7) * 5 / 100;
        }

        else if (layout == "cross-country")
        {
            if (juniors+seniors >= 50)
            {
                sum = ((juniors * 8 + seniors * 9.5) - (juniors * 8 + seniors * 9.5) * 25 / 100) - (((juniors * 8 + seniors * 9.5) - (juniors * 8 + seniors * 9.5) * 25 / 100) * 5/100);
            }
            else
            {
                sum = (juniors * 8 + seniors * 9.5) - ((juniors * 8 + seniors * 9.5) * 5 / 100);
            }
        }

        else if (layout == "road")
        {
            sum = (juniors * 20 + seniors * 21.5) - (juniors * 20 + seniors * 21.5) * 5 / 100;
        }

        else if (layout == "downhill")
        {
            sum = (juniors * 12.25 + seniors * 13.75) - (juniors * 12.25 + seniors * 13.75) * 5 / 100;
        }

        Console.WriteLine("{0:f2}", sum);
    }
}

