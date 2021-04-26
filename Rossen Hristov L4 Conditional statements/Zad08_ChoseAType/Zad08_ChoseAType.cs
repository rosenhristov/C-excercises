using System;

    class Zad08_ChoseAType
    {
        static void Main()
        {
            Console.Write(@"Please chose the type of what you'd like to enter:
'0' for string
'1' for integer
2' for real number.

Make your choice: ");
            int choice = int.Parse(Console.ReadLine());

            bool string_ = (choice == 0);
            bool integer = (choice == 1);
            bool realNumber = (choice == 2);

            if (string_ == true)
            {
                Console.WriteLine("Enter your string: ");
                string @string = Console.ReadLine();
                Console.WriteLine(@string + "*");
            }
            else if (integer == true)
            {
                Console.Write("Enter your integer: ");
                int integ = int.Parse(Console.ReadLine());
                Console.WriteLine("The reasult is: " + (integ + 1));
            }
            else if (realNumber == true)
            {
                Console.Write("Enter your real number: ");
                double realNum = double.Parse(Console.ReadLine());
                Console.WriteLine("The result is: " + (realNum + 1));
            }
        }
    }
