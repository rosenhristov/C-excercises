using System;

class Zad5_TrapeziumArea
{
    static void Main()
    {
        Console.Write("Trapecium base a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Trapecium base b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Trapecium Height h = ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("trapeciumArea = " + ((a + b) * h / 2));

    }
}