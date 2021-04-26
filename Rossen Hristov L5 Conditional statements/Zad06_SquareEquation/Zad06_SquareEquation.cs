using System;

    class Zad06_SquareEquation
    {
        static void Main()
        {
            Console.Write("Enter coefficient 'a': ");
            double coeffA = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient 'b': ");
            double coeffB = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient 'c': ");
            double coeffC = double.Parse(Console.ReadLine());

            double determinant = Math.Pow(coeffB, 2) - (4 * coeffA * coeffC);

            Console.WriteLine("The determinant D = {0}", determinant);

            if (determinant == 0)
            {
                double rootX1 = (coeffB * (-1)) / (2.0 * coeffA);
                Console.WriteLine("x1 = {0}", rootX1);
            }

            if (determinant > 0)
            {
                double rootX1 = ((coeffB * (-1)) + Math.Sqrt(determinant)) / (2 * coeffA);
                double rootX2 = ((coeffB * (-1)) - Math.Sqrt(determinant)) / (2 * coeffA);
                Console.WriteLine(rootX1);
                Console.WriteLine(rootX2);
            }
            else if (determinant < 0)
            {
                Console.WriteLine("Determinant is negative.");
                Console.Write("The sqare equation does not have real roots \n");
            }
        }
    }
