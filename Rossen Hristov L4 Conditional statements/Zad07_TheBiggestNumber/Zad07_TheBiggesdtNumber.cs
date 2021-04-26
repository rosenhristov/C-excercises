using System;

class TheBiggestNumber
{
    static void Main()
    {
        Console.Write("Enter number #1: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter number #2: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Enter number #3: ");
        double num3 = double.Parse(Console.ReadLine());
        Console.Write("Enter number #4: ");
        double num4 = double.Parse(Console.ReadLine());
        Console.Write("Enter number #5: ");
        double num5 = double.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            if (num2 > num3)
            {
                if (num3 > num4)
                {
                    if (num4 > num5)
                    {
                        Console.WriteLine("The biggest number is: " + num1);
                    }
                    else// num4 < num5
                    {
                        if (num1 > num5)
                        {
                            Console.WriteLine("The biggest number is: " + num1);
                        }
                        else//num1 > num5
                        {
                            Console.WriteLine("The biggest number is: " + num5);
                        }
                    }
                }
                else//num3 < num4
                {
                    if (num4 > num5)
                    {
                        if (num1 > num4)
                        {
                            Console.WriteLine("The biggest number is: " + num1);
                        }
                        else//num1 < num4
                        {
                            Console.WriteLine("The biggest number is: " + num4);
                        }
                    }
                    else//num4 < num5
                    {
                        if (num1 > num5)
                        {
                            Console.WriteLine("The biggest number is: " + num1);
                        }
                        else//num1 < num5
                        {
                            Console.WriteLine("The biggest number is: " + num5);
                        }
                    }
                }
            }
            else// num2 < num3
            {
                if (num3 > num4)
                {
                    if (num4 > num5)
                    {
                        if (num1 > num3)
                        {
                            Console.WriteLine("The biggest number is: " + num1);
                        }
                        else//num1 < num3
                        {
                            Console.WriteLine("The biggest number is: " + num3);
                        }

                    }
                    else//num4 < num5
                    {
                        if (num1 > num5)
                        {
                            Console.WriteLine("The biggest number is: " + num1);
                        }
                        else//num1 < num5
                        {
                            Console.WriteLine("The biggest number is: " + num5);
                        }
                    }
                }
                else//num3 < num4
                {
                    if (num4 > num5)
                    {
                        if (num1 > num4)
                        {
                            Console.WriteLine("The biggest number is: " + num1);
                        }
                        else//num1 < num4
                        {
                            Console.WriteLine("The biggest number is: " + num4);
                        }
                    }
                    else//num4 < num5
                    {
                        if (num1 > num5)
                        {
                            Console.WriteLine("The biggest number is: " + num1);
                        }
                        else//num1 < num5
                        {
                            Console.WriteLine("The biggest number is: " + num5);
                        }

                    }
                }
            }
        }
        else//num1 < num2
        {
            if (num2 > num3)
            {
                if (num3 > num4)
                {
                    if (num4 > num5)
                    {
                        Console.WriteLine("The biggest number is: " + num2);
                    }
                    else//num4< num5
                    {
                        if (num2 > num5)
                        {
                            Console.WriteLine("The biggest number is: " + num2);
                        }
                        else//num2 < num5
                        {
                            Console.WriteLine("The biggest number is: " + num5);
                        }
                    }
                }
                else//num3 < num4
                {
                    if (num4 > num5)
                    {
                        if (num2 > num4)
                        {
                            Console.WriteLine("The biggest number is: " + num2);
                        }
                        else//num2 < num4
                        {
                            Console.WriteLine("The biggest number is: " + num4);
                        }
                    }
                    else//num4 < num5
                    {
                        if (num2 > num5)
                        {
                            Console.WriteLine("The biggest number is: " + num2);
                        }
                        else//num2 < num5
                        {
                            Console.WriteLine("The biggest number is: " + num5);
                        }
                    }
                }
            }
            else//num2 < num3
            {
                if (num3 > num4)
                {
                    if (num4 > num5)
                    {
                        Console.WriteLine("The biggest number is: " + num3);
                    }
                    else//num4 < num5
                    {
                        if (num3 > num5)
                        {
                            Console.WriteLine("The biggest number is: " + num3);
                        }
                        else//num3 < num5
                        {
                            Console.WriteLine("The biggest number is: " + num5);
                        }
                    }
                }
                else// num3 < num4
                {
                    if (num4 > num5)
                    {
                        Console.WriteLine("The biggest number is: " + num4);
                    }
                    else//num4 < num5
                    {
                        Console.WriteLine("The biggest number is: " + num5);
                    }
                }
            }
        }
    }
}
