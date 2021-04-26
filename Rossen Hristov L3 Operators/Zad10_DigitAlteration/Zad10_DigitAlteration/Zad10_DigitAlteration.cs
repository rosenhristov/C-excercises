using System;

    class Zad10_DigitAlteration
    {
        static void Main()
        {
            Console.Write("Insert as four-digit nmber: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int digit4 = number % 10;
            int number2 = number / 10;
            int digit3 = number2 % 10;
            int number3 = number2 / 10;
            int digit2 = number3 % 10;
            int digit1 = number3 / 10;
            Console.WriteLine("Digit № 1 is: " + digit1);
            Console.WriteLine("Digit № 2 is: " + digit2);
            Console.WriteLine("Digit № 3 is: " + digit3);
            Console.WriteLine("Digit № 4 is: " + digit4);
            Console.WriteLine("The sum of the digits is: " + (digit1 + digit2 + digit3 + digit4));
            Console.WriteLine("The number with reversed order of the digits is: " + digit4 + digit3 + digit2 + digit1);
            Console.WriteLine("The number with reversed order of digits 2 and 3 is: " + digit1 + digit3 + digit2 + digit4);
        }
    }
