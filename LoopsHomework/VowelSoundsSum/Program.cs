using System;
class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int vowelSum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            switch (text[i])
            {
                case 'a':
                    vowelSum += 1;
                    break;
                case 'e':
                    vowelSum += 2;
                    break;
                case 'i':
                    vowelSum += 3;
                    break;
                case 'o':
                    vowelSum += 4;
                    break;
                case 'u':
                    vowelSum += 5;
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine(vowelSum);
    }
}

