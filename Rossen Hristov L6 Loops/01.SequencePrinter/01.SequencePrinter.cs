using System;

class SequencePrinter
{
    static void Main()
    {

        //Write a program that prints all the numbers from 1 to N.

        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= number)
        {
            Console.WriteLine(counter);
            counter++;
        }
    }
}
