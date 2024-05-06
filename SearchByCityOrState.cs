
using AddressBook;
namespace AddressBook
{
    public class SearchByCityOrState
    {
        public List<Contacts> SearchContactsByCity(Dictionary<string, Address_Book> addressBooks, string city)
        {
            List<Contacts> results = new List<Contacts>();
            foreach (var bookEntry in addressBooks.Values)
            {
                foreach (var contact in bookEntry.contacts)
                {
                    if (contact.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                    {
                        results.Add(contact);
                    }
                }
            }
            return results;
        }

        public List<Contacts> SearchContactsByState(Dictionary<string, Address_Book> addressBooks, string state)
        {
            List<Contacts> results = new List<Contacts>();
            foreach (var bookEntry in addressBooks.Values)
            {
                foreach (var contact in bookEntry.contacts)
                {
                    if (contact.State.Equals(state, StringComparison.OrdinalIgnoreCase))
                    {
                        results.Add(contact);
                    }
                }
            }
            return results;
        }
    }
}