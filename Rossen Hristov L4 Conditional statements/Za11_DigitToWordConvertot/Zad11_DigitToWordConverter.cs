using System;

    class Zad11_DigitToWordConvwerter
    {
        static void Main()
        {
            Console.Write("Enter an integer between 0 and 999: ");
            int number = int.Parse(Console.ReadLine());

            int units = number % 10;
            int decimals = (number / 10) % 10;
            int hundreds = number / 100;

            Console.WriteLine(" ");

            switch (hundreds)
            {
                case 0: Console.Write(" "); break;
                case 1: Console.Write("сто"); break;
                case 2: Console.Write("двеста"); break;
                case 3: Console.Write("триста"); break;
                case 4: Console.Write("четиристотин"); break;
                case 5: Console.Write("петстотин"); break;
                case 6: Console.Write("шестотин"); break;
                case 7: Console.Write("седемстотин"); break;
                case 8: Console.Write("осемстотин"); break;
                case 9: Console.Write("деветстотин"); break;
            }

            if (decimals == 0)
            {
                if (units == 0)
                {
                    Console.WriteLine(" ");
                }

            }
            else
            {
                if (decimals == 1)
                {
                    Console.Write(" и ");
                }
                else
                {
                    if (units == 0)
                    {
                        Console.Write(" и ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }

            switch (decimals)
            {
                case 0: Console.Write(" "); break;
                case 1:
                    switch (units)
                    {
                        case 0: Console.Write("десет"); break;
                        case 1: Console.Write("единадесет"); break;
                        case 2: Console.Write("дванадесет"); break;
                        case 3: Console.Write("тринадесет"); break;
                        case 4: Console.Write("четиринадесет"); break;
                        case 5: Console.Write("петнадесет"); break;
                        case 6: Console.Write("шестнадесет"); break;
                        case 7: Console.Write("седемнадесет"); break;
                        case 8: Console.Write("осемнадесет"); break;
                        case 9: Console.Write("деветнадесет"); break;
                    }
                    break;
                case 2: Console.Write("двадесет "); break;
                case 3: Console.Write("тридесет "); break;
                case 4: Console.Write("четиридесет "); break;
                case 5: Console.Write("петдесет "); break;
                case 6: Console.Write("шестдесет "); break;
                case 7: Console.Write("седемдесет "); break;
                case 8: Console.Write("осемдесет "); break;
                case 9: Console.Write("деветдесет "); break;
            }

            if (decimals != 1)
            {
                if (units != 0)
                    Console.Write(" и ");

                switch (units)
                {
                    case 0: Console.Write(" "); break;
                    case 1: Console.Write("едно"); break;
                    case 2: Console.Write("две"); break;
                    case 3: Console.Write("три"); break;
                    case 4: Console.Write("четири"); break;
                    case 5: Console.Write("пет"); break;
                    case 6: Console.Write("шест"); break;
                    case 7: Console.Write("седем"); break;
                    case 8: Console.Write("осем"); break;
                    case 9: Console.Write("девет"); break;
                }
            }


            Console.WriteLine(" ");
        }
    }
