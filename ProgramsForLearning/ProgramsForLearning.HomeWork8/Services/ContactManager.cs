using ProgramsForLearning.HomeWork8.Contracts;
using ProgramsForLearning.HomeWork8.Models;

namespace ProgramsForLearning.HomeWork8.Services
{
    public class ContactManager : IContactManager
    {
        private List<Contact> _contacts = new List<Contact>();

        //public ContactManager()
        //{
        //    _contacts = new List<Contact>();
        //}
        public List<Contact> ListContacts()
        {
            return _contacts;
        }
        public void AddContact(Contact contact)
        {
            int newId = _contacts.Count + 1;
            contact.Id = newId;
            _contacts.Add(contact);
        }
         
        public void UpdateContact(Contact contact)
        {
            Contact existingContact = _contacts[contact.Id - 1];
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
        public void DeleteContact(int id)
        {
            // Contact existingContact;
            Contact existingContact = _contacts[id - 1];
            // Contact existingContact = _contacts.Where(p => p.Id == id).FirstOrDefault();
            //foreach (Contact contact in _contacts)
            //{
            //    if (contact.Id == id)
            //    {
            //        existingContact = contact;
            //        break;
            //    }
            //}
            if (existingContact != null)
            {
                _contacts.RemoveAt(id - 1);
            }

        }

    }
}
