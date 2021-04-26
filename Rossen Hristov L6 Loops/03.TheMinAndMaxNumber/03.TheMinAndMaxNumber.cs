using System;

class TheMinAndMaxNumber
{
    static void Main()
    {
        /*
        Write a program that reads from the console a sequence of N integer numbers
        and returns the minimal and maximal of them.
        */

        Console.Write("Enter the number of the members of the sequence: n = ");
        int membersNumber = int.Parse(Console.ReadLine());
        int minValue = 0;
        int maxValue = 0;
        int temp = 0;

        for (int i = 1; i <= membersNumber; i++)
        {
            Console.Write("Enter a member of the sequence: m = ");
            int member = int.Parse(Console.ReadLine());
            Console.WriteLine(member + " ");

            if (i == 1)
            {
                if (member > 0)
                {
                    maxValue = member;
                    Console.WriteLine("The Max value is {0}. The Min value is {1}.", maxValue, minValue);
                }
                else
                {
                    minValue = member;
                    Console.WriteLine("The Max value is {0}. The Min value is {1}.", maxValue, minValue);
                }

            }

            else if (i == 2)
            {
                if (member > maxValue)
                {

                    minValue = maxValue;
                    maxValue = member;
                    Console.WriteLine("The Max value is {0}. The Min value is {1}.", maxValue, minValue);
                }
                else
                {
                    minValue = member;
                    Console.WriteLine("The Max value is {0}. The Min value is {1}.", maxValue, minValue);
                }

            }
            else
            {

                if (member > minValue)
                {
                    if (member > maxValue)
                    {
                        maxValue = member;
                        Console.WriteLine("The Max value is {0}. The Min value is {1}.", maxValue, minValue);
                    }
                    else
                    {
                        Console.WriteLine("The Max value is {0}. The Min value is {1}.", maxValue, minValue);
                    }
                }
                else
                {
                    minValue = member;
                    Console.WriteLine("The Max value is {0}. The Min value is {1}.", maxValue, minValue);
                }
            }
        }
    }
}
