using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n != 0 && (n<100 || n>200))
        {
            Console.WriteLine("invalid");
        }
        else if (n>=100 && n<=200)
        {

        }
    }
}

