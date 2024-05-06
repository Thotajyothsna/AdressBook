namespace AddressBook
{ 
public class Address_Book
{
    public List<Contacts> contacts = new List<Contacts>();

    public void AddContact(Contacts contact)
    {
        contacts.Add(contact);
    }

    public void DisplayContacts()
    {
        foreach (var contact in contacts)
        {
            Console.WriteLine($"Name: {contact.Firstname} {contact.Lastname}, Phone: {contact.Phonenumber}, Email: {contact.Email}, Address: {contact.Address}, City: {contact.City}, State: {contact.State}, Zipcode: {contact.Zip}");
        }
    }
}

public class AddressBookManager
{
    public Dictionary<string, Address_Book> addressBooks = new Dictionary<string, Address_Book>();

    public void AddAddressBook(string name)
    {
        if (!addressBooks.ContainsKey(name))
        {
            addressBooks.Add(name, new Address_Book());
            Console.WriteLine($"Address book '{name}' added successfully.");
        }
        else
        {
            Console.WriteLine($"Address book '{name}' already exists.");
        }
    }

    public void AddContactToAddressBook(string addressBookName, Contacts contact)
    {
        if (addressBooks.ContainsKey(addressBookName))
        {
            addressBooks[addressBookName].AddContact(contact);
            Console.WriteLine($"Contact added to '{addressBookName}' address book.");
        }
        else
        {
            Console.WriteLine($"Address book '{addressBookName}' does not exist.");
        }
    }

    public void DisplayAddressBook(string name)
    {
        if (addressBooks.ContainsKey(name))
        {
            Console.WriteLine($"Contacts in address book '{name}':");
            addressBooks[name].DisplayContacts();
        }
        else
        {
            Console.WriteLine($"Address book '{name}' does not exist.");
        }
    }
}
}