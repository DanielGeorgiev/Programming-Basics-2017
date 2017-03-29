using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = 0;
        int firstNumber = int.Parse(Console.ReadLine());
        min = firstNumber;

        for (int i = 0; i < n-1; i++)
        {
            int secondNumber = int.Parse(Console.ReadLine());
            if (secondNumber<min)
            {
                min = secondNumber;
            }
        }

        Console.WriteLine(min);
    }
}