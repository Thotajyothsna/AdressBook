using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class ContactsCountByCityOrState
    {
        public int CountContactsByCity(string city, CityStateAddressBook cityStateAddressBook)
        {
            if (cityStateAddressBook.cityContacts.ContainsKey(city))
            {
                return cityStateAddressBook.cityContacts[city].Count;
            }
            else
            {
                Console.WriteLine($"No contacts found for city '{city}'.");
                return 0;
            }
        }

        public int CountContactsByState(string state, CityStateAddressBook cityStateAddressBook)
        {
            if (cityStateAddressBook.stateContacts.ContainsKey(state))
            {
                return cityStateAddressBook.stateContacts[state].Count;
            }
            else
            {
                Console.WriteLine($"No contacts found for state '{state}'.");
                return 0;
            }
        }
    }

}
