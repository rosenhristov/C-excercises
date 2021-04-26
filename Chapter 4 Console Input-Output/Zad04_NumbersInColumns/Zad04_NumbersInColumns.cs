Cusing System;

{
    class Zad04_NumbersInColumns
    {
        static void Main()
        {
            int number1 = 256;
            double number2 = 123.456;
            double number3 = -105.125;
            Console.WriteLine("The three numbers are: ");
            Console.WriteLine(" ");
            Console.WriteLine("| " + "{0,-10:X}" + "| " + "{1,-10:N2}" + "| " + "{2,-10:N2}" + "|", number1, number2, number3);
            // "|" are the virtual borders of the columns
        }
    }
}
