using ProgramsForLearning.Program10.Contracts;
using ProgramsForLearning.Program10.Models;

namespace ProgramsForLearning.Program10.Services
{
    public class ContactManager //: IContacManager
    {
        private List<Contact> _contacts = new List<Contact>();

        public Contact GetContactById(int id)
        {
            //var contact=  _contacts.FirstOrDefault(contact => contact.Id == id);
            // return contact;
            //var ddd =    _contacts.Where(contact => contact.Id == id).FirstOrDefault();

            //Contact contactInDb;
            //foreach (Contact contact in _contacts)
            //{
            //    if (contact.Id == id)
            //    {
            //        contactInDb = contact;
            //        break;
            //    }
            //}
            return _contacts.FirstOrDefault(contact => contact.Id == id);
        }

        public Contact GetContactByName(string name)
        { 
            return _contacts.FirstOrDefault(contact => contact.Name == name);
        }
        public List<Contact> GetContactsSortedByName()
        {
            return _contacts.OrderByDescending( p=> p.Name).ToList();
        }
        public List<Contact> GetContacts()
        {
            return _contacts;
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void AddContacts(List<Contact> contacts)
        { 
            //foreach (Contact contact in contacts)
            //{
            //    _contacts.Add(contact); 
            //}
            _contacts.AddRange(contacts);
        }
        public void UpdateContact(Contact contact)
        {
            var existingContact = GetContactById(contact.Id);
            if (existingContact != null)
            {
                existingContact.Address = contact.Address;
                existingContact.Age = contact.Age;
                existingContact.Email = contact.Email;
                existingContact.Name = contact.Name;
                existingContact.LastName = contact.LastName;

                //_contacts.Remove(existingContact);
                //_contacts.Add(contact);  
            }
        }

        public void DeleteContact(int id)
        {
            var existingContact = GetContactById(id);
            if (existingContact != null)
            {
                _contacts.Remove(existingContact);
            }
        }
    }
}
