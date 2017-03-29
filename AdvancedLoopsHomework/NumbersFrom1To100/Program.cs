using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number in the range [1...100]: ");
        int number = int.Parse(Console.ReadLine());

        for (; ; )
        {
            if (number >= 1 && number <= 100)
            {
                Console.WriteLine(number);
                break;
            }
            else
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range [1...100]: ");
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}

