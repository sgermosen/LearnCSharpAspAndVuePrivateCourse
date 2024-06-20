 

namespace ProgramsForLearning.HomeWork10
{
    public class ContactManager  
    {
        private List<Contact> _contacts = new List<Contact>();
        private Dictionary<int, Contact> _contactDictionary = new Dictionary<int, Contact>();

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
            _contactDictionary[contact.Id] = contact;
        }

        public void UpdateContact(Contact contact)
        {
            var existingContact = _contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (existingContact != null)
            {
                existingContact.Name = contact.Name;
                existingContact.LastName = contact.LastName;
                existingContact.Email = contact.Email;
                existingContact.Phone = contact.Phone;
            }
            _contactDictionary[contact.Id] = contact;
        }

        public void DeleteContact(int contactId)
        {
            var contact = _contacts.FirstOrDefault(c => c.Id == contactId);
            if (contact != null)
            {
                _contacts.Remove(contact);
                _contactDictionary.Remove(contactId);
            }
        }

        public IEnumerable<Contact> ListContacts()
        {
            return _contacts;
        }

        //public IEnumerable<object> ListContactsAsAnonymous()
        public IEnumerable<dynamic> ListContactsAsAnonymous()
        {
            return _contacts.Select(c => new { FullName = $"{c.Name} {c.LastName}", c.Email });
        }

        public Contact GetContactById(int contactId)
        {
            _contactDictionary.TryGetValue(contactId, out var contact);
            return contact;
        }

        public IEnumerable<Contact> FilterContactsByLastName(string lastName)
        {
            return _contacts.Where(c => c.LastName == lastName);

        }
        public void SortContactsByFirstName()
        {
            _contacts = _contacts.OrderBy(c => c.Name).ToList();
        }

    }
}