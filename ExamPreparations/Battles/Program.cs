using System;
class Program
{
    static void Main()
    {
        // 90 tochki v judge-a batioooo
        int firstPokemons = int.Parse(Console.ReadLine()); // 2
        int secondPokemons = int.Parse(Console.ReadLine()); // 2
        int maxBattles = int.Parse(Console.ReadLine()); // 6
        int newFirstPokemons = 1;
        int newSecondPokemons = 1;
        int updateNewSecondPokemons = 1;

        for (int i = 0; i < maxBattles; i++)
        {
            Console.Write("({0} <-> {1}) ", newFirstPokemons, newSecondPokemons);
            newSecondPokemons++;
            if (newSecondPokemons>secondPokemons)
            {
                newFirstPokemons++;
                newSecondPokemons = updateNewSecondPokemons;
            }
            if (newFirstPokemons > firstPokemons && newSecondPokemons < secondPokemons)
            {
                break;
            }
        }
    }
}
