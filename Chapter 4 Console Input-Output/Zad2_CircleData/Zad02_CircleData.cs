using System;

class Zad02_CircleData
    {
        static void Main()
        {
            Console.Write("Enter the value of a circle radius in cm: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * (double)Math.PI * radius;
            double area = (double)Math.PI * radius * radius;
            Console.WriteLine("Circle Radius: " + "{0}", radius + " cm");
            Console.WriteLine("Circle Perimeter: " + "{0}", perimeter + " cm");
            Console.WriteLine("Circle Area, sq. cm: " + "{0}", area + " sq. cm");
        }
    }
