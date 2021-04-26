using System;

class Sample
{
    static void Main()
    {
        Console.Write("Enter an integer N = ");
        decimal number = int.Parse(Console.ReadLine());
        int digit = 0;
        decimal factorial = 1;
        decimal remainder;
        int sum = 0;

        while (number >= 1)
        {
            factorial *= number;
            number--;
        }
        Console.WriteLine(" N! = {0:N0}", factorial);

        while (digit == 0)
        {
            digit = (int)factorial % 10;
            if (digit == 0)
            {
                sum += 1;
            }
            remainder = (int)factorial / 10;
            factorial = remainder;
        }
        Console.WriteLine("The number of zeros in N! is: {0}", sum);
    }
}
