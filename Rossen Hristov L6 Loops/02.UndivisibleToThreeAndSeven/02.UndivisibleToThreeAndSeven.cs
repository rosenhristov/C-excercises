using System;

class UndevisibleToThreeAndSeven
    {
        static void Main()
        {

            /* Write a program that prints all the numbers from 1 to N,
            that are not divisible by 3 and 7 at the same time.
             */

            Console.Write("n = ");
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 != 0)
                {
                    if (i % 7 != 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                       continue;
                    }
                }
                else
                {
                    continue;
                }
            }
        }
    }

