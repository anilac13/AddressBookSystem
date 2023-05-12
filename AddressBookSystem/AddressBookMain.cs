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
    }
}
