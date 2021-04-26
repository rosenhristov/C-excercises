using System;

    class Zad6_RectangleCalculator
    {
        static void Main()
        {
            Console.Write("Enter rectangle side'a': ");
            int sideA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter rectangle side'b': ");
            int sideB = Convert.ToInt32(Console.ReadLine());
            int rectanglePerimeter = 2*(sideA + sideB);
            int rectangleArea = sideA * sideB;
            Console.WriteLine(rectanglePerimeter);
            Console.WriteLine(rectangleArea);
        }
    }
