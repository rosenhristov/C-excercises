using System;

    class Zad03_CompanyInfo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Company Name: ");
            string company = Console.ReadLine();

            Console.Write("Enter Company Adrees: ");
            string address = Console.ReadLine();

            Console.Write("Enter Company's Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("Enter Company's Fax Number ");
            string fax = Console.ReadLine();

            Console.Write("Enter Company's Website: ");
            string website = Console.ReadLine();

            string contactPerson = "contact person:";
            Console.WriteLine(contactPerson);

            Console.Write("Enter Contact Person's Name: ");
            string managerName = Console.ReadLine();

            Console.Write("Enter Contact Person's Surname: ");
            string managerSurname = Console.ReadLine();

            Console.Write("Enter manager Phone number: ");
            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine("Dear Sirs, ");
            Console.WriteLine("Our company is {0}, the address of our Headquaters is: {1}. ", company, address);
            Console.Write("In case you would like to contact us please call us at {0} or send a fax to {1}. ", phone, fax);
            Console.Write("If you are interested in our products please take a closer look at our website: {0}. ", website);
            Console.Write("You can forward your inquiries to the following {0} : {1} {2}. ", contactPerson, managerName, managerSurname);
            Console.Write("His phone number is: {0} ", managerPhoneNumber);
        }
    }
