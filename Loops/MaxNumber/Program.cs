using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int max = 0;
        int firstNumber = int.Parse(Console.ReadLine());
        max = firstNumber;

        for (int i = 0; i < n-1; i++)
        {
            int readNum = int.Parse(Console.ReadLine());
            if (readNum>max)
            {
                max = readNum;
            }
        }
        Console.WriteLine(max);
    }
}
