using System;
class Program
{
    static void Main()
    {
        decimal kgVegetablesPrice = decimal.Parse(Console.ReadLine());
        decimal kgFruitsPrice = decimal.Parse(Console.ReadLine());
        decimal kgVegetables = decimal.Parse(Console.ReadLine());
        decimal kgFruits = decimal.Parse(Console.ReadLine());

        decimal vegetables = kgVegetablesPrice * kgVegetables;
        decimal fruits = kgFruitsPrice * kgFruits;

        decimal sum = (vegetables + fruits) / 1.94m;
        Console.WriteLine("{0:f0}",sum);

    }
}

