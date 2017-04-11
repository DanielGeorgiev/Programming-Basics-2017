using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        string birthDate = Console.ReadLine();
        DateTime date = DateTime.ParseExact(birthDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime afterBirth = date.AddDays(999);
        Console.WriteLine(afterBirth.ToString("dd-MM-yyyy"));
    }
}

