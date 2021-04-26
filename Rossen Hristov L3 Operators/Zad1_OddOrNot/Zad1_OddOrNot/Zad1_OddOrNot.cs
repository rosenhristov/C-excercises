using System;

    class Zad1_OddOrNot
    {
        static void Main()
        {
            Console.WriteLine("EVEN OR ODD CHECKER");
            
            Console.WriteLine(" ");
            
            Console.WriteLine("VARIANT 1: ");
            Console.WriteLine(" ");
            Console.Write("Please Enter a value: ");

            int x = int.Parse(Console.ReadLine()); //the number is even if x%2==0
            Console.WriteLine(x % 2 == 0);
            Console.WriteLine("if the answer is 'True' the number is even, otherwise it is odd");

            Console.WriteLine(" ");

            Console.WriteLine("VARIANT 2: ");
            Console.WriteLine(" ");
            Console.Write("Please Enter a value: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(y % 2 != 0);//the numberr is odd if x % 2 != 0)
            Console.WriteLine("if the answer is 'True' the number is odd, otherwise it is even");
        }
    }
