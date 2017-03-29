using System;
class Program
{
    static void Main()
    {
        string figure = Console.ReadLine();

        if (figure=="square")
        {
            Console.Write("Enter the square's side: ");
            double a = double.Parse(Console.ReadLine());
            double result = a * a;
            Console.WriteLine("The area is: {0}",result);
        }
        else if (figure=="rectangle")
        {
            Console.Write("Enter the rectangle's sides: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = a*b;
            Console.WriteLine("The area is: {0}",result);
        }
        else if (figure=="circle")
        {
            Console.Write("Enter the circle's radius: ");
            double radius = double.Parse(Console.ReadLine());
            double result = radius*radius*Math.PI;
            Console.WriteLine("The area is: {0}",Math.Round(result,2));
        }
        else if (figure=="triangle")
        {
            Console.Write("Enter the triangle's side and height: ");
            double h = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());
            double result = h * side / 2;
            Console.WriteLine("The area is: {0}",result);
        }
    }
}

