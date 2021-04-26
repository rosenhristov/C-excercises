using System;

    class Zad09_SquareEquationSolver
    {
        static void Main()
        {
            Console.Write("coefficient a = ");
            double coefficientA = double.Parse(Console.ReadLine());

            Console.Write("coefficient b = ");
            double coefficientB = double.Parse(Console.ReadLine());

            Console.Write("coefficient c = ");
            double coefficientC = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}.x^2 + {1}.x + {2}", coefficientA, coefficientB, coefficientC);

            Console.WriteLine(coefficientB * coefficientB);

            double determinant = (coefficientB * coefficientB) - (4 * coefficientA * coefficientC);
            Console.WriteLine("D = {0}", determinant);

            double rootX1 = ((-1) * coefficientB + Math.Sqrt(determinant)) / (2 * coefficientA);
            double rootX2 = ((-1) * coefficientB - Math.Sqrt(determinant)) / (2 * coefficientA);

            Console.WriteLine("x1 = {0}", rootX1);
            Console.WriteLine("x2 = {1}", rootX2);
        }
    }
