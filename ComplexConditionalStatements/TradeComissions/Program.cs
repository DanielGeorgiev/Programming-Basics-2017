using System;
class Program
{
    static void Main()
    {
        string city = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());
        double comission = 0;
        bool isError = false;

        if (city!="sofia" && city!="varna" && city!="plovdiv" || sales<0)
        {
            isError = true;
        }

        if (sales>=0 && sales<=500)
        {
            if (city=="sofia")
            {
                comission = sales * 0.05;
            }
            else if (city=="varna")
            {
                comission = sales * 0.045;
            }
            else if (city=="plovdiv")
            {
                comission = sales * 0.055;
            }
        }
        else if (sales>500 && sales<=1000)
        {
            if (city == "sofia")
            {
                comission = sales * 0.07;
            }
            else if (city == "varna")
            {
                comission = sales * 0.075;
            }
            else if (city == "plovdiv")
            {
                comission = sales * 0.08;
            }
        }
        else if (sales>1000 && sales<=10000)
        {
            if (city == "sofia")
            {
                comission = sales * 0.08;
            }
            else if (city == "varna")
            {
                comission = sales * 0.10;
            }
            else if (city == "plovdiv")
            {
                comission = sales * 0.12;
            }
        }
        else 
        {
            if (city == "sofia")
            {
                comission = sales * 0.12;
            }
            else if (city == "varna")
            {
                comission = sales * 0.13;
            }
            else if (city == "plovdiv")
            {
                comission = sales * 0.145;
            }
        }
        if (isError==true)
        {
            Console.WriteLine("error");
        }
        else 
        {
            Console.WriteLine("{0:f2}",comission);
        }
    }
}

