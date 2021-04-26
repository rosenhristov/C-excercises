using System;


class Zad9_InsideCircleAndRectangle
{
    static void Main()
    {
        double radiusOfK = 5; //radius of a circle K
        Console.Write("Enter coordinate 'x' of dot O: ");
        double DotOCoordinateX = double.Parse(Console.ReadLine());
        Console.Write("Enter coordinate 'y' of dot O: ");
        double DotOCoordinateY = double.Parse(Console.ReadLine());
        Console.WriteLine
        ((DotOCoordinateX * DotOCoordinateX + DotOCoordinateX * DotOCoordinateX) <= (radiusOfK * radiusOfK) ? "inside K" : "outside K");
        Console.WriteLine
            (DotOCoordinateY < 1 ? "outside rectangle" : "inside rectangle");
    }
}