using System;

    class Zad12_Workers
    {
        static void Main()
        {
            Console.Write("Вашето име: ");
            string firstName = Console.ReadLine();
            Console.Write("Вашата фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Вашият пол - \'м\' или \'ж\' : ");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Вашата възраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Вашият служебен номер: ");
            uint personalID = uint.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("ДАННИ ЗА СЛУЖИТЕЛЯ:");
            Console.WriteLine(" ");
            Console.WriteLine("Име: " + firstName);
            Console.WriteLine("Фамилия: " + surname);
            Console.WriteLine("Пол: " + gender);
            Console.WriteLine("Възраст: " + age);
            Console.WriteLine("Служебен номер: " + personalID);
        }
    }
