using ProgramsForLearning.Program11.Exceptions;
using ProgramsForLearning.Program11.Helpers.Validators;
using ProgramsForLearning.Program11.Models;

namespace ProgramsForLearning.Program11
{
    public class ContactManager
    {
        private List<Contact> _contacts = new List<Contact>();

        public Contact GetContactById(int id)
        {
            return _contacts.FirstOrDefault(contact => contact.Id == id);
        }

        public void AddContact(ContactModel contact)
        {
            //try
            //{
                var contactDb = new Contact();
                contactDb.Id = Convert.ToInt32(contact.Id);
                contactDb.Email = contact.Email;
                contactDb.Address = contact.Address;
                contactDb.Name = contact.Name;
                contactDb.LastName = contact.LastName;
                contactDb.Age = contact.Age;

                ContactValidator.Valitate(contactDb);

                _contacts.Add(contactDb);
            //}
            //catch (ArgumentException ex)
            //{// throw new Exception(ex.Message);
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("error agregando el registro");
            //}
            //finally
            //{  // Loggin
            //    Console.WriteLine($"Se ejecutó el metodo{nameof(AddContact)}");
            //}

        }

        public void UpdateContact(Contact contact)
        {
            var existingContact = GetContactById(contact.Id);
            if (existingContact == null)
            {
                // throw new Exception($"No se encontró un contacto con el id:{contact.Id}");
              //  throw new ContactNotFoundException($"No se encontró un contacto con el id:{contact.Id}");
                throw new GenericNotFoundException<Contact>($"No se encontró un contacto con el id:{contact.Id}");
            }
            //if (existingContact != null)
            //{
            ContactValidator.Valitate(existingContact);

            existingContact.Address = contact.Address;
            existingContact.Age = contact.Age;
            existingContact.Email = contact.Email;
            existingContact.Name = contact.Name;
            existingContact.LastName = contact.LastName;
            //}

        }
    }
}
