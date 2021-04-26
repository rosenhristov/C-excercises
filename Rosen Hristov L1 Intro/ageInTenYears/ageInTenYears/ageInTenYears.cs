using System;

class ageInTenYears
{
    static void Main()
    {
        Console.Write("Please, whrite your current age here: ");
        int ageNow = int.Parse(Console.ReadLine());
        int ageInTenYears = ageNow + 10;
        Console.WriteLine(ageInTenYears);
    }
}