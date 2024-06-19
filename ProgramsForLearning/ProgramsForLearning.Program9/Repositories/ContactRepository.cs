using ProgramsForLearning.Program9.Contracts;
using ProgramsForLearning.Program9.Models;

namespace ProgramsForLearning.Program9.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly List<Contact> _contacts = new List<Contact>();

        public Contact GetById(int id)
        {
            //  _contacts.FirstOrDefault(c => c.Id == id);   
            return _contacts.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Contact> GetAll()
        {
            return _contacts;
        }

        public void Add(Contact contact)
        {
            int newId = _contacts.Count + 1;
            contact.Id = newId;
            _contacts.Add(contact);
        }

        public void Update(Contact contact)
        {
            Contact existingContact = GetById(contact.Id);

            if (existingContact != null)
            {
                existingContact.Email = contact.Email;
                existingContact.Address = contact.Address;
                existingContact.Phone = contact.Phone;
                existingContact.LastName = contact.LastName;
                existingContact.Age = contact.Age;
                existingContact.Name = contact.Name;

                _contacts.RemoveAt(contact.Id - 1);
                _contacts.Add(existingContact);
            }
        }

        public void Delete(int id)
        {
            Contact existingContact = GetById(id);

            if (existingContact != null)
            {
                _contacts.RemoveAt(id - 1);
            }
        }

    }
}
