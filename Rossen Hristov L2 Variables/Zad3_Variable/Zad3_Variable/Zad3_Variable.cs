using System;

    class Zad3_Variable
    {
        static void Main()
        {
            //Calculastes the value of VAT (Value Added Tax 20%) and the total sum ("Total to Be Paid")
            //when the user enters the value of the Sum wihout VAT
             Console.Write("SUM = ");
            decimal sumWithoutVAT = decimal.Parse(Console.ReadLine());
            decimal valueOfVAT = sumWithoutVAT * 0.2m;
            decimal totalToBePaid = sumWithoutVAT + valueOfVAT;
            Console.WriteLine("VAT = " + valueOfVAT);
            Console.WriteLine ("TOTAL SUM = " + totalToBePaid);

        }
    }
