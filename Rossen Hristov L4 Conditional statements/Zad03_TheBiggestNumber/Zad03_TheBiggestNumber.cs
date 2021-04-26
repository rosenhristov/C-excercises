using System;

class Zad03_TheBiggestNumber
    {
        static void Main()
        {
            Console.Write("Enter a real number: ");
            double number1 = double.Parse(Console.ReadLine());
            
            Console.Write("Enter a real number: ");
            double number2 = double.Parse(Console.ReadLine());
            
            Console.Write("Enter a real number: ");
            double number3 = double.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                if (number2 > number3)
                {
                    Console.WriteLine("The biggest number is: " + number1);
                }
                else//number2 < number3
                {
                    if (number1 > number3)
                    {
                        Console.WriteLine("The biggest number is: " + number1);
                    }
                    else
                    {
                        Console.WriteLine("The biggest number is: " + number3);
                    }
                }
            }
            else//number1 < number2
            {
                if (number2 > number3)
                {
                    Console.WriteLine("The biggest number is: " + number2);
                }
                else//number2 < number3
                {
                    Console.WriteLine("The biggest number is: " + number3);
                }

            }
        }
    }
