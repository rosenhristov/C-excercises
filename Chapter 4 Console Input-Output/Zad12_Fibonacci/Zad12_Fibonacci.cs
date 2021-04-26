using System;

    class Zad12_Fibonacci
    {
        static void Main()
        {
            int n = 100;
            int firstMember = 0;
            int secondMemebr = 1;
            // n ограницава размера на редицата
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                firstMember = secondMemebr;
                secondMemebr = temp + secondMemebr;
                Console.WriteLine(firstMember);
            }
        }
    }
