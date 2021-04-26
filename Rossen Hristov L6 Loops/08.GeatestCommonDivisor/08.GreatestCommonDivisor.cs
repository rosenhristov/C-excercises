
using System;

class GreatestCommonDivisor
{
    static void Main()
    {

        /* Write a program that calculates the greatest common divisor (GCD) of given two numbers.
           Use the Euclidean algorithm (find it in Internet).
        */

        Console.WriteLine("  GREATEST COMMON DIVISOR GCD(N,M):");
        Console.WriteLine("  ----------------------------------");
        Console.WriteLine(" Enter the values of 'N' & 'M':");
        Console.Write(" N = ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write(" M = ");
        int numM = int.Parse(Console.ReadLine());

        int commonDivisor;//CD = Common Divisor
        int remainder;
        int tempRem;//temporary variable that keeps the previous value of 'remainder'
        int gcd; //The Greatest Common Divisor (GCD)
        int tempCD;//temporary variable that keeps the previous value of 'commonDivisor'

        if (numN == numM)
        {
            gcd = numN;
            Console.WriteLine("The GCD({0},{1}) = {2}", numN, numM, gcd);
        }
        else
        {

            if (numN > numM)
            {
                //Step #1 Bigger number / Smallewr number
                commonDivisor = numN / numM;
                remainder = numN - commonDivisor * numM;
                gcd = remainder;
                if (remainder == 0)
                {
                    Console.WriteLine("The GCD ({0},{1}) = {2}", numN, numM, gcd);
                }
                else
                {
                    Console.WriteLine("CD = {0} Remainder = {1}", commonDivisor, remainder);//4 12
                }
                tempRem = remainder;

                //Step #2 Smaller number / remainder
                commonDivisor = numM / remainder;
                remainder = numM - commonDivisor * remainder;
                gcd = tempRem;
                if (remainder == 0)
                {
                    Console.WriteLine("The GCD ({0},{1}) = {2}", numN, numM, gcd);
                }
                else
                {
                    tempRem = remainder;
                    Console.WriteLine("CD = {0} Remainder = {1}", commonDivisor, remainder);
                }
                tempRem = remainder;

                //Steps from 3 to 'n': remainder (i) / remainder (i-1)  
                while (remainder != 0)
                {
                    tempCD = commonDivisor;
                    commonDivisor = tempRem / remainder;
                    remainder = tempRem - tempCD * tempRem;
                    commonDivisor = tempRem;
                    Console.WriteLine("CD = {0} Remainder = {1}", commonDivisor, remainder);
                    gcd = tempRem;
                    if (remainder == 0)
                    {
                        Console.WriteLine("The GCD({0},{1}) = {2}", numN, numM, gcd);
                    }
                    else
                    {

                        tempRem = remainder;
                    }
                }
            }
            else
            {
                //Step #1 Bigger number / Smallewr number
                commonDivisor = numM / numN;
                remainder = numM - commonDivisor * numN;
                gcd = remainder;
                if (remainder == 0)
                {
                    Console.WriteLine("The GCD ({0},{1}) = {2}", numN, numM, gcd);
                }
                else
                {

                    Console.WriteLine("CD = {0} Remainder = {1}", commonDivisor, remainder);
                }
                tempRem = remainder;

                //Step #2 Smaller number / remainder
                commonDivisor = numN / remainder;
                remainder = numN - commonDivisor * remainder;
                gcd = tempRem;
                if (remainder == 0)
                {
                    Console.WriteLine("The GCD ({0},{1}) = {2}", numN, numM, gcd);
                }
                else
                {
                    tempRem = remainder;//
                    Console.WriteLine("CD = {0} Remainder = {1}", commonDivisor, remainder);
                }
                tempRem = remainder;

                //Steps from 3 to n: remainder (i) / remainder (i-1)
                while (remainder != 0)
                {
                    tempCD = commonDivisor;
                    commonDivisor = tempRem / remainder;
                    remainder = tempRem - tempCD * tempRem;
                    commonDivisor = tempRem;
                    Console.WriteLine("CD = {0} Remainder = {1}", commonDivisor, remainder);
                    gcd = tempRem;
                    if (remainder == 0)
                    {
                        Console.WriteLine("The GCD({0},{1}) = {2}", numN, numM, gcd);
                    }
                    else
                    {
                        tempRem = remainder;

                    }
                }
            }
        }
    }
}
