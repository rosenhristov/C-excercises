using System;


    class Zad8_InsideACircle
    {
        static void Main()
        {
            double radiusOfK = 5; //radius of a circle K
            Console.Write("Enter coordinate 'x' of a dot: ");
            double dotOCoordinateX = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate 'y' of a dot: ");
            double dotOCoordinateY = double.Parse(Console.ReadLine());
            Console.WriteLine((dotOCoordinateX*dotOCoordinateX + dotOCoordinateY*dotOCoordinateY) <= (radiusOfK*radiusOfK) ? "inside K": "outside K");
        }
    }
