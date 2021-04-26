using System;

    class Zad01_ValueExchange
    {
        static void Main()
        {
            Console.Write("Enter an integer #1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer #2: ");
            int number2 = int.Parse(Console.ReadLine());
            int temp; //temporary variable for exchange of the other two variables'values

            if (number1 > number2)
            {
                temp = number1;
                number1 = number2;
                number2 = temp;
                Console.WriteLine("The new value of number1 is: " + number1);
                Console.WriteLine("The new value of number2 is: " + number2);
            }
        }
    }
