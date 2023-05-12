using System;
namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookMain main = new AddressBookMain();
            main.AddContact();
            main.Display();
        }
    }
}