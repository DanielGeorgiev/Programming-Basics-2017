using System;
class Program
{
    static void Main()
    {
        string projectionType = Console.ReadLine().ToLower();
        uint row = uint.Parse(Console.ReadLine());
        uint column = uint.Parse(Console.ReadLine());
        decimal result = 0;

        if (projectionType=="premiere")
        {
            result = (row * column) * 12.00m;
        }
        else if (projectionType=="normal")
        {
            result = (row * column) * 7.50m;
        }
        else if (projectionType=="discount")
        {
            result = (row * column) * 5.00m;
        }
        Console.WriteLine("{0:f2} leva",result);
    }
}

