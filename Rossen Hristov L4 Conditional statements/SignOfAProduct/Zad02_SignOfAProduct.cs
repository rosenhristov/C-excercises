using System;

class Zad02_SignOfAProduct
    {
        static void Main()
        {
            Console.Write("Ënter a real number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Ënter a real number: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.Write("Ënter a real number: ");
            double number3 = double.Parse(Console.ReadLine());

            if (number1 < 0.0)
            {
                if (number2 < 0)
                {
                    if (number3 < 0)
                    {
                        Console.WriteLine("The product of the three numbers is negative: '-'.");
                    }
                    else
                    {
                        Console.WriteLine("The product of the three numbers is positive: '+'.");
                    }
                }
                else
                {
                    if (number3 < 0)
                    {
                        Console.WriteLine("The product of the three numbers is positive: '+'.");
                    }
                    else
                    {
                        Console.WriteLine("The product of the three numbers is negative: '-'.");
                    }

                }
            }
            else
            {
                if (number2 < 0.0)
                {
                    if (number3 < 0.0)
                    {
                        Console.WriteLine("The product of the three numbers is positive: '+'.");
                    }
                    else
                    {
                        Console.WriteLine("The product of the three numbers is negative: '-'.");
                    }
                }
                else
                {
                    if (number3 < 0.0)
                    {
                        Console.WriteLine("The product of the three numbers is negative: '-'.");
                    }
                    else
                    {
                        Console.WriteLine("The product of the three numbers is positive: '+'.");
                    }

                }

            }

        }
    }
