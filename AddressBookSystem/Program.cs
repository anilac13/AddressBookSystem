using System;
using System.Net;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookMain main = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Create contacts in address book \n2.Add contact \n3.Edit contact \n4.Delete contact \n5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        main.Display();
                        break;
                    case 2:
                        Console.WriteLine("Enter first name");
                        main.AddContact();
                        main.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter first name to edit");
                        string name = Console.ReadLine();
                        main.EditContact(name);
                        main.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter first name to delete");
                        string firstName = Console.ReadLine();
                        main.DeleteContact(firstName);
                        main.Display();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}