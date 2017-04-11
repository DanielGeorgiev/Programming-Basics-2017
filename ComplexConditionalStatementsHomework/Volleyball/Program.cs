using System;
class Program
{
    static void Main()
    {
        string year = Console.ReadLine();

        double holidays = uint.Parse(Console.ReadLine());
        double weekends = uint.Parse(Console.ReadLine());

        double bornCityWeekends = 0;
        double bornCityHolidays = 0;
        double total = 0;

        if (year=="leap")
        {
            bornCityWeekends = 48 - weekends;
            bornCityWeekends = bornCityWeekends * (3.0 / 4);
            bornCityHolidays = holidays * 2.0 / 3;
            total = bornCityWeekends + bornCityHolidays + weekends;
            total = total + (total * 15.0 / 100);
        }
        else if (year=="normal")
        {
            bornCityWeekends = 48 - weekends;
            bornCityWeekends = bornCityWeekends * (3.0 / 4);
            bornCityHolidays = holidays * 2.0 / 3;
            total = bornCityWeekends + bornCityHolidays + weekends;
        }
        Console.WriteLine(Math.Truncate(total));
    }
}

