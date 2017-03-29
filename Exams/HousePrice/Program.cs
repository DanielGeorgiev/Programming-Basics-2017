using System;
class Program
{
    static void Main()
    {
        double smallestRoomArea = double.Parse(Console.ReadLine());
        double kitchenArea = double.Parse(Console.ReadLine());
        double squareMeterPrice = double.Parse(Console.ReadLine());

        double secondRoom = smallestRoomArea + (smallestRoomArea * 10.0 / 100.0);
        double thirdRoom = secondRoom + (secondRoom * 10.00 / 100.00);
        double bathroom = smallestRoomArea / 2.0;
        double sum = smallestRoomArea + kitchenArea + secondRoom + thirdRoom + bathroom;

        Console.WriteLine("{0:f2}",(sum + (sum * 5.0 / 100.0)) * squareMeterPrice);
    }
}

