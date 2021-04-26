using System;

class Zadacha10
{
    static void Main()
    {
        int member = 2;
        while (member <= 101)
        {
            if (member % 2 == 0)
            {
                Console.WriteLine(member);
            }
            else
                Console.WriteLine(member * (-1));
            member++;
        }
    }
}