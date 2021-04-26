using System;

    class Zad09_ZeroMultitudes
    {
        static void Main()
        {
            Console.Write("Enter an integer #1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter an integer #2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter an integer #3: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Enter an integer #4: ");
            int num4 = int.Parse(Console.ReadLine());

            Console.Write("Enter an integer #5: ");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("The Sequence of the numbers is: {0}, {1}, {2}, {3}, {4}", num1, num2, num3, num4, num5);




            // e.g. 'sum1234' means: the sum of 'num1', 'num2', 'num3, 'num4'.
            // The names of the other sums are analogical.

            switch (num1 + num2 + num3 + num4 + num5)
            {
                case 0:
                    Console.WriteLine("The sum of all the five integers is equal to 0!"); break;
                default:
                    Console.WriteLine("The sum of all the five integers is not equal to 0"); break;
            }

            switch (num1)
            {
                case 0:
                    Console.WriteLine("Integer #1 is equal to 0"); break;
                default:
                    Console.WriteLine("Integer #1 is not equal to 0"); break;
            }

            switch (num1 + num2)
            {
                case 0:
                    Console.WriteLine("The sum of {0} and {1} is equal to 0!", num1, num2); break;
                default:
                    Console.WriteLine("The sum of {0} and {1} is not equal to '0'!", num1, num2); break;
            }

            switch (num1 + num2 + num3)
            {
                case 0:
                    Console.WriteLine("The sum of {0}, {1} and {2} is equal to '0'!", num1, num2, num3); break;
                default:
                    Console.WriteLine("The sum of {0}, {1} and {2} is not equal to '0'!", num1, num2, num3); break;
            }

            switch (num1 + num2 + num3 + num4)
            {
                case 0:
                    Console.WriteLine("The sum of {0}, {1}, {2} and {3} is equal to '0'!", num1, num2, num3, num4); break;
                default:
                    Console.WriteLine("The sum of {0}, {1}, {2} and {3} is not equal to '0'!", num1, num2, num3, num4); break;
            }

            switch (num2)
            {
                case 0:
                    Console.WriteLine("Integer #2 is equal to 0"); break;
                default:
                    Console.WriteLine("Integer #2 is not equal to 0"); break;
            }

            switch (num2 + num3)
            {
                case 0:
                    Console.WriteLine("The sum of {0} and {1} is equal to '0'!", num2, num3); break;
                default:
                    Console.WriteLine("The sum of {0} and {1} is not equal to '0'!", num2, num3); ; break;
            }

            switch (num2 + num3 + num4)
            {
                case 0:
                    Console.WriteLine("The sum of {0}, {1} and {2} is equal to '0'!", num2, num3, num4); break;
                default:
                    Console.WriteLine("The sum of {0}, {1} and {2} is not equal to '0'!", num2, num3, num4); break;
            }

            switch (num2 + num3 + num4 + num5)
            {
                case 0:
                    Console.WriteLine("The sum of {0}, {1}, {2} and {3} is equal to '0'!", num2, num3, num4, num5); break;
                default:
                    Console.WriteLine("The sum of {0}, {1}, {2} and {3} is not equal to '0'!", num2, num3, num4, num5); break;
            }

            switch (num3)
            {
                case 0:
                    Console.WriteLine("Integer #3 is equal to '0'"); break;
                default:
                    Console.WriteLine("Integer #3 is not equal to '0'"); break;
            }

            switch (num3 + num4)
            {
                case 0:
                    Console.WriteLine("The sum of {0} and {1} is equal to '0'!", num3, num4); break;
                default:
                    Console.WriteLine("The sum of {0} and {1} is not equal to '0'!", num3, num4); break;
            }

            switch (num3 + num4 + num5)
            {
                case 0:
                    Console.WriteLine("The sum of {0}, {1} and {2} is equal to '0'!", num3, num4, num5); break;
                default:
                    Console.WriteLine("The sum of {0}, {1} and {2} is not equal to '0'!", num3, num4, num5); break;
            }

            switch (num4)
            {
                case 0:
                    Console.WriteLine("Integer #4 equals '0'"); break;
                default:
                    Console.WriteLine("Integer #4 is not equal to '0'"); break;
            }

            switch (num4 + num5)
            {
                case 0:
                    Console.WriteLine("The sum of {0} and {1} is '0'.", num4, num5); break;
                default:
                    Console.WriteLine("The sum of {0} and {1} is not '0'.", num4, num5); break;
            }

            switch (num5)
            {
                case 0:
                    Console.WriteLine("Integer #5 is equal to 0"); break;
                default:
                    Console.WriteLine("Onteger #5 is not equal to 0"); break;
            }
        }
    }
