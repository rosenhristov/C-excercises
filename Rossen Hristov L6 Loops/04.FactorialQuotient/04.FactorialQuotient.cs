using System;


class FactorialQuotient
{
    static void Main()
    {
        //Write a program that calculates N!/K! for given N and K (1<K<N).


        Console.Write("Enter value of N (N > 1), N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value of K (K = (1:N)), K = ");
        int k = int.Parse(Console.ReadLine());

        decimal nFactorial = 1;
        decimal kFactorial = 1;

        while (n >= 1)
        {
            nFactorial *= n;
            n--;

            while (k >= 1)
            {

                kFactorial *= k;
                k--;
            }

        }
        Console.WriteLine("N! = {0}", nFactorial);
        Console.WriteLine("K! = {0}", kFactorial);
        Console.WriteLine("N!/K! = {0}", (nFactorial / kFactorial));
    }
}
