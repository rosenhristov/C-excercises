using System;

    class Zad8_Hello_World
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object obj = hello + " " + world;
            string str = (string)obj;
            Console.WriteLine(str);
        }
    }
