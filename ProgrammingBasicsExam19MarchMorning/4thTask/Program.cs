using System;
class Program
{
    static void Main()
    {
        double lectures = double.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());
        double jelev = 0;
        double royal = 0;
        double trofon = 0;
        double roli = 0;
        double sino = 0;
        double others = 0;
        double newBudget = budget/lectures;

        for (int i = 0; i < lectures; i++)
        {
            string lecturer = Console.ReadLine();

            if (lecturer == "Jelev")
            {
                jelev++;
            }
            else if (lecturer == "RoYaL")
            {
                royal++; 
            }
            else if (lecturer == "Roli")
            {
                roli++;
            }
            else if (lecturer == "Trofon")
            {
                trofon++;
            }
            else if (lecturer == "Sino")
            {
                sino++;
            }
            else
            {
                others++;
            }   
        }

        Console.WriteLine("Jelev salary: {0:f2} lv", jelev*newBudget);
        Console.WriteLine("RoYaL salary: {0:f2} lv", royal*newBudget);
        Console.WriteLine("Roli salary: {0:f2} lv", roli*newBudget);
        Console.WriteLine("Trofon salary: {0:f2} lv", trofon*newBudget);
        Console.WriteLine("Sino salary: {0:f2} lv", sino*newBudget);
        Console.WriteLine("Others salary: {0:f2} lv", others*newBudget);
    }
}

