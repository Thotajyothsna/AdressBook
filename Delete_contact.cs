﻿﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static AddressBook.CustomException;


namespace AddressBook
{
    class DeleteContact
    {  
        public  void DeletingContacts(List<Contacts> list)
        {
            try
            {
                Console.Write("If you wanna exit press Y + enter else anyChar + enter = ");
                char chooseExit = char.Parse(Console.ReadLine());
                if (chooseExit == 'Y' || chooseExit == 'y') return;

                Console.WriteLine("Deleting Contacts");
                Console.Write("Enter the First name: ");
                string firstname = Console.ReadLine();
                Console.Write("Enter the Last name: ");
                string lastname = Console.ReadLine();

                if (firstname.Length == 0 || lastname.Length == 0)
                {
                    throw new StringEmptyException();
                }
                else if (firstname.Length > 0 && lastname.Length > 0)
                {
                    if (list.Any((contacts) => contacts.Firstname == firstname && contacts.Lastname == lastname))
                    {
                        foreach (Contacts item in list)
                        {
                            if (item.Firstname == firstname && item.Lastname == lastname)
                            {
                                Console.WriteLine("Confirm delation !");
                                Console.Write("Press Y || y for YES = ");
                                char decision = char.Parse(Console.ReadLine());
                                if (decision == 'Y' || decision == 'y')
                                {
                                    list.Remove(item);
                                  
                                    Console.WriteLine("Successfully deleted !");
                                    return;
                                }
                                else
                                {
                                    throw new InvalidInputException();
                                }
                            }
                            else
                            {
                                throw new ContactNotFoundException();
                            }
                        }
                    }
                    else
                    {
                        throw new ContactNotFoundException();
                    }
                }
            
            }
            catch { DeletingContacts(list); }
        }
    }
}