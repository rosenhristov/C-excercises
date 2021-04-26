using System;

class NMembersOfFibonacciSeq
{
    static void Main()
    {
        /*
            Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
         */

        Console.WriteLine("***FIBONACCI SEQUENCE***\n");
        Console.WriteLine("------------------------\n");
        Console.WriteLine("Please enter the number of members you wish to calculate:\n");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        decimal memberOne = 0;
        decimal memberTwo = 1;
        Console.WriteLine("*** THE FIRST 'N' MEMBERS OF FIBONACCI SEQUENCE ARE: ***\n");
        Console.WriteLine("    N |                  Value");
        Console.WriteLine("-----------------------------------------------");

        int k; //we need 'k' in order to calculate (n/2)*2 members if n is even or ((n/2)*2)-1 membersif 'n' is odd.
        if (n % 2 == 0)//n is even
        {
            k = n / 2;//'k' is an integer
        }
        else//'k' is a real number (n % 2 != 0), so the calculated members will be (n-1) ((n(int)/2 = k(real)-0.5). Therefore 'k' must be:
        {
            k = (n / 2) + 1;// k(int) = k(real) + 0.5, that will give (n + 1) members of the sequence in the loop
        }

        for (int i = 1; i <= k; i++)
        {
            Console.WriteLine("{0,5} | {1,-39}", i * 2 - 1, memberOne);

            if (n % 2 != 0)
            {
                if (i != k)
                {
                    Console.WriteLine("{0,5} | {1,-39}", i * 2, memberTwo);
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("{0,5} | {1,-39}", i * 2, memberTwo);
            }

            memberOne = memberOne + memberTwo;
            memberTwo = memberTwo + memberOne;
        }
        Console.WriteLine();

        /*  What are the 'if-else' constructions needed for?
       Every iteration of the loop 'for' writes 2 members of the Fibonacci sequence on the console.
       If 'N' is an even number (e.g. 26) the loop needs to iterate n/2 = k = 13 times and will write 13*2=26 memebers of the sequence. That's fine.
            However, if ' N' is an odd number (e.g. 25) the loop cannot be repeated n/2 = 12.5 times! 'N' is an integer (int),
       i.e. n/2 = 25/2 = 12 in this case(because n % 2 != 0).
            Therefore, the loop will repeat 12 times and will write 12*2 = 24 members. But N = 25, i.e. we need 25, not 24 members.
        Consequeently, we neeed to repeat the loop 13 times to get (n+1) Fibonacci numbers and at the final (13th in that example) iteration we have to write only 'memberOne'
       (which is the 25th member in all the iterations of the loop) and to miss the 26th member ('memberTwo' at the 13th iteration in the example).
       Thus, the loop will successfully write exactly the odd number of members (in this example 25).
       */
    }
}
