using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        List<Contacts> addressList = new List<Contacts>();
        public AddressBookMain()
        {
            Contacts contact1 = new Contacts()
            {
                firstName = "Anil",
                lastName = "Kumar",
                address = "Bangalore",
                city = "Bangalore",
                state = "Karnataka",
                zipcode = "563123",
                phoneNumber = "6789012345",
                email = "a@gamil.com"
            };
            Contacts contact2 = new Contacts()
            {
                firstName = "Soma",
                lastName = "Shekar",
                address = "Bangalore",
                city = "Bangalore",
                state = "Karnataka",
                zipcode = "563123",
                phoneNumber = "6789012345",
                email = "s@gamil.com"
            };
            addressList.Add(contact1);
            addressList.Add(contact2);
        }
        public void AddContact()
        {
            Contacts contact = new Contacts()
            {
                firstName = Console.ReadLine(),
                lastName = Console.ReadLine(),
                address = Console.ReadLine(),
                city = Console.ReadLine(),
                state = Console.ReadLine(),
                zipcode = Console.ReadLine(),
                phoneNumber = Console.ReadLine(),
                email = Console.ReadLine(),
            };
            addressList.Add(contact);
        }
        public void Display()
        {
            foreach (var data in addressList)
            {
                Console.WriteLine("First name: " + data.firstName + "\n" + "Last name: " + data.lastName + "\n" +
                      "Address: " + data.address + "\n" + "City: " + data.city + "\n" + "State: " + data.state + "\n" +
                    "ZIP: " + data.zipcode + "\n" + "Phone number: " + data.phoneNumber + "\n" + "E-Mail: " + data.email);
            }
        }
        public void EditContact(string name)
        {
            foreach (var data in addressList)
            {
                if (data.firstName.ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine("\nChoose option to edit contact \n1.Last name \n2.Address \n3.City \n4.State \n5.ZIP \n6.Phone number \n7.E-Mail");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            data.lastName = Console.ReadLine();
                            break;
                        case 2:
                            data.address = Console.ReadLine();
                            break;
                        case 3:
                            data.city = Console.ReadLine();
                            break;
                        case 4:
                            data.state = Console.ReadLine();
                            break;
                        case 5:
                            data.zipcode = Console.ReadLine();
                            break;
                        case 6:
                            data.phoneNumber = Console.ReadLine();
                            break;
                        case 7:
                            data.email = Console.ReadLine();
                            break;
                    }
                }
            }
        }
    }
}
