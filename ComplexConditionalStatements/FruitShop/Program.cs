using System;
class Program
{
    static void Main()
    {
        string fruit = Console.ReadLine().ToLower();
        string dayOfWeek = Console.ReadLine().ToLower();

        decimal quantity = decimal.Parse(Console.ReadLine());
        decimal price = -0.1m;

            if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
            {
                if (fruit == "banana")
                {
                    price = 2.50m;
                }
                else if (fruit == "apple")
                {
                    price = 1.20m;
                }
                else if (fruit == "orange")
                {
                    price = 0.85m;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45m;
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70m;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50m;
                }
                else if (fruit == "grapes")
                {
                    price = 3.85m;
                }
            }


            else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.70m;
                }
                else if (fruit == "apple")
                {
                    price = 1.25m;
                }
                else if (fruit == "orange")
                {
                    price = 0.90m;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60m;
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00m;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60m;
                }
                else if (fruit == "grapes")
                {
                    price = 4.20m;
                }
        }
            if (price>=0)
            {
                Console.WriteLine("{0:f2}",price*quantity);
            }
            else
            {
                Console.WriteLine("error");
            }
    }
}

