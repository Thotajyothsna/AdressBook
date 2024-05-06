using AddressBook;
using System.Collections.ObjectModel;

public class CityStateAddressBook
{
    public ObservableCollection<Contacts> allContacts = new ObservableCollection<Contacts>();
    public Dictionary<string, ObservableCollection<Contacts>> cityContacts = new Dictionary<string, ObservableCollection<Contacts>>();
    public Dictionary<string, ObservableCollection<Contacts>> stateContacts = new Dictionary<string, ObservableCollection<Contacts>>();

    public void AddContactToAddressBook(string addressBookName, Contacts contact, AddressBookManager addressBookManager)
    {
        if (addressBookManager.addressBooks.ContainsKey(addressBookName))
        {
            addressBookManager.addressBooks[addressBookName].AddContact(contact);

            // Update allContacts ObservableCollection
            allContacts.Add(contact);

            // Update cityContacts dictionary
            if (!cityContacts.ContainsKey(contact.City))
            {
                cityContacts.Add(contact.City, new ObservableCollection<Contacts>());
            }
            cityContacts[contact.City].Add(contact);

            // Update stateContacts dictionary
            if (!stateContacts.ContainsKey(contact.State))
            {
                stateContacts.Add(contact.State, new ObservableCollection<Contacts>());
            }
            stateContacts[contact.State].Add(contact);

            Console.WriteLine($"Contact added to '{addressBookName}' address book.");
        }
        else
        {
            Console.WriteLine($"Address book '{addressBookName}' does not exist.");
        }
    }
}