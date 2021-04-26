using System;

    class Zad14_IfItIsASimpleNumber
    {
        static void Main()
        {
            Console.Write("Enter a positive number in the interval \"1 to 100\": ");
            int number = int.Parse(Console.ReadLine());
            int divider = 2;
            int dividerMaxValue = (int)Math.Sqrt(number);
            bool prime = true;
            
            while (prime && (divider <= dividerMaxValue))
            {
                if (number % divider == 0)
                {
                        prime = false;
                }
            
            divider++;
            }

                Console.WriteLine("Prime: " + prime);
         }
    }
