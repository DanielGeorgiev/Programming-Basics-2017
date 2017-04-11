using System;
class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a>b)
        {
            Console.WriteLine("Greater: {0}",a);   
        }
        else
        {
            Console.WriteLine("Greater: {0}",b);
        }
    }
}

