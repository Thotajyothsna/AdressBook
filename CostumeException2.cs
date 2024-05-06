﻿//using RegexProblems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AddressBook.CustomException;
namespace AddressBook
{
   public  class AddDetails
    {
        int ContinueAddingContacts;
        public  void AddingDetails(List<Contacts> list)
        {
            try
            {
                Validation validation = new Validation();
                do
                {
                    Console.Write("If you wanna exit press Y + enter else anyChar + enter = ");
                    char choice = char.Parse(Console.ReadLine());
                    if (choice == 'Y' || choice == 'y') return;

                    Console.Write("\nEnter the first name = ");
                    string firstname = Console.ReadLine();
                    if (!validation.IsName(firstname)) throw new InvalidNameException();

                    Console.Write("Enter the last name = ");
                    string lastname = Console.ReadLine();
                    if (validation.IsName(lastname) == false) throw new InvalidNameException();

                    // if (SearchContact.DoesExist(list, firstname, lastname)) throw new ContactAlreadyExistsException();

                    Console.Write("Enter the email = ");
                    string email = Console.ReadLine();
                    if (!validation.IsEmail(email)) throw new InvalidEmailException();

                    Console.Write("Enter the phone number = ");
                    string phonenumber = Console.ReadLine();
                    if (!validation.IsNumber(phonenumber)) throw new InvalidNumberException();

                    Console.Write("Enter the address = ");
                    string address = Console.ReadLine();

                    Console.Write("Enter the city = ");
                    string city = Console.ReadLine();

                    Console.Write("Enter the state = ");
                    string state = Console.ReadLine();

                    Console.Write("Enter the ZipCode = ");
                    string zipcode = Console.ReadLine();
                    if (!validation.IsZipCode(zipcode)) throw new InvalidZipCodeException();

                    if (string.IsNullOrEmpty(address) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state)) throw new StringEmptyException();

                    Contacts contacts = new Contacts(firstname, lastname, email, phonenumber, address, city, state, zipcode);

                    list.Add(contacts);
                    Console.WriteLine("DO YOU WANT TO ADD CONTACT AGAIN? THEN PRESS 1 ELSE ANY DIGIT");
                    ContinueAddingContacts=Convert.ToInt32(Console.ReadLine());
                } while (ContinueAddingContacts == 1);
            }
            catch{ AddingDetails(list); }                       
            
        }
        public void display(List<Contacts> list)
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