using System;

class FactorialQuotient2
{
    static void Main()
    {
        //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

        /* Let's introduce a third variable M = K-N,
           then N!*K! / (K-N)! = N!*K! / M!.
           Thus, we will have three loops: one for K!, other for N! and a third loop for M!.
           K > N > 1, consequently K - N = M > 0, thus M! > 0
         */

        Console.Write("Enter value of K (K > 1), K = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter value of N (N = [1:K]), N = ");
        int n = int.Parse(Console.ReadLine());

        int m = k - n;

        decimal nFactorial = 1;
        decimal kFactorial = 1;
        decimal mFactorial = 1;

        while (k >= 1)
        {
            kFactorial *= k;
            k--;

            while (n >= 1)
            {

                nFactorial *= n;
                n--;

                while (m >= 1)
                {
                    mFactorial *= m;
                    m--;
                }
            }
        }
        Console.WriteLine("K! = {0}", kFactorial);
        Console.WriteLine("N! = {0}", nFactorial);
        Console.WriteLine("N! * K!/(N - K)! = {0}", (nFactorial * kFactorial / mFactorial));
    }
}
