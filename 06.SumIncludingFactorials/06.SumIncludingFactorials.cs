using System;

class SumIncludingFactorials
{
    static void Main()
    {

        /*
            Write a program that, for a given two integer numbers N and X, calculates the sum:
            S = 1 + (1!/X) + (2!/X^2) + … + (N!/X^N)
        */

        Console.Write("N= ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("X= ");
        double x = double.Parse(Console.ReadLine());

        double factorial = 1;// F == [1:n]
        double sum = 1;//S == [1 : (1 + (1!/x) + (2!/x^2) + ... + (n!/x^n))]

        for (int i = 1; i <= n; i++)
        {
            while (n >= 1)
            {
                factorial *= n;
                Console.WriteLine(factorial);
                n--;
            }
            sum += (factorial / (Math.Pow(x, n)));
            n--;
        }

        Console.WriteLine("Final S = 1 + (1!/x) + (2!/x^2) +...+ (n!/x^n) = {0}", sum);
    }
}
