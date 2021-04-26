using System;

    class Zad10_BonusPoints
    {
        static void Main()
        {
            Console.Write("Enter your points: ");
            int points = int.Parse(Console.ReadLine());

            switch (points)
            {
                case 1:
                    Console.WriteLine("Your result is: " + (points * 10)); break;
                case 2:
                    Console.WriteLine("Your result is: " + (points * 10)); break;
                case 3:
                    Console.WriteLine("Your result is: " + (points * 10)); break;
                case 4:
                    Console.WriteLine("Your result is: " + (points * 100)); break;
                case 5:
                    Console.WriteLine("Your result is: " + (points * 100)); break;
                case 6:
                    Console.WriteLine("Your result is: " + (points * 100)); break;
                case 7:
                    Console.WriteLine("Your result is: " + (points * 1000)); break;
                case 8:
                    Console.WriteLine("Your result is: " + (points * 1000)); break;
                case 9:
                    Console.WriteLine("Your result is: " + (points * 1000)); break;
                default:
                    Console.WriteLine("You have entered an invalid number. Please enter a number in the range from 0 to 9"); break;
            }
        }
    }
