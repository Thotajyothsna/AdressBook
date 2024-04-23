using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security;
using AddressBook;

namespace AddressBook
{
    class Adddetails
    {
        static ArrayList list = new ArrayList();
        public void Addingdetails()
        {
            Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter your Address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter your City");
            string city = Console.ReadLine();

            Console.WriteLine("Enter your State");
            string state = Console.ReadLine();

            Console.WriteLine("Enter your zip code");
            string zip = Console.ReadLine();

            Console.WriteLine("Enter your phone number");
            string phonenumber = Console.ReadLine();

            Console.WriteLine("Enter your Email");
            string email = Console.ReadLine();


            Contacts customer1 = new Contacts(firstname, lastname, address, city, state, zip, phonenumber, email);

            list.Add(customer1);

        }

        public void display()
        {
            foreach (Contacts person in list)
            {

                Console.WriteLine($"First Name: {person.Firstname}");
                Console.WriteLine($"Last Name: {person.Lastname}");
                Console.WriteLine($"Address: {person.Address}");
                Console.WriteLine($"City: {person.City}");
                Console.WriteLine($"State: {person.State}");
                Console.WriteLine($"Zip Code: {person.Zip}");
                Console.WriteLine($"Phone Number: {person.Phonenumber}");
                Console.WriteLine($"Email: {person.Email}");
            }

        }
    }
}