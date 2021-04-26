using System;

class CathalanNumbers
{
    static void Main(string[] args)
    {
        /*
            In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
            Cn = (2n)!/((n+1)!.n!)
            Write a program to calculate the Nth Catalan number by given N.

         */

        Console.Write(" Enter a number >= 0; N = ");
        decimal n = decimal.Parse(Console.ReadLine());
        decimal k = 2 * n;
        decimal j = n + 1;
        decimal factorialN = 1;
        decimal factorialK = 1;
        decimal factorialJ = 1;
        decimal numberOfCathalan = 1;

        if (n == 0)
        {
            factorialN = 1;//n! = 0! = 1
            numberOfCathalan = factorialN / factorialN * factorialN;//Cn = (2.0)! / ((0 + 1)! * 0!) = 0! / (0! * 0!) = 1 / (1 * 1) = 1
            Console.WriteLine();
            Console.WriteLine("Cn = {0}", numberOfCathalan);
        }
        else if (n > 0)
        {
            while (n >= 1)
            {
                factorialN *= n;
                n--;
            }
            Console.WriteLine();
            Console.WriteLine("n! = {0:N0}", factorialN);
            
            while (k >= 1)
            {
                factorialK *= k;
                k--;
            }
            Console.WriteLine();
            Console.WriteLine("(2n)! = {0:N0}", factorialK);

            while (j >= 1)
            {
                factorialJ *= j;
                j--;
            }
            Console.WriteLine();
            Console.WriteLine("(n + 1)! = {0:N0}", factorialJ);
                
            numberOfCathalan = factorialK / (factorialJ * factorialN);
            Console.WriteLine();
            Console.WriteLine("Cn = {0:N0}", numberOfCathalan);
                
           
        }
    }
}
