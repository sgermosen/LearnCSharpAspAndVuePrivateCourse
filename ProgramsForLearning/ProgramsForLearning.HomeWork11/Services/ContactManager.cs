using ProgramsForLearning.HomeWork11.Exceptions;
using ProgramsForLearning.HomeWork11.Helpers;

namespace ProgramsForLearning.HomeWork11.Services
{
    public class ContactManager
    {
        private List<Contact> _contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            ContactValidator.Validate(contact);
            if (_contacts.Any(c => c.Id == contact.Id))
            {
                throw new DuplicateContactException($"Contact with ID {contact.Id} already exists.");
            }

        }

        public void UpdateContact(Contact contact)
        {
            ContactValidator.Validate(contact);
            try
            {

                var existingContact = _contacts.FirstOrDefault(c => c.Id == contact.Id);
                if (existingContact == null)
                {
                    throw new ContactNotFoundException($"Contact with ID {contact.Id} not found.");
                }
                existingContact.Name = contact.Name;
                existingContact.LastName = contact.LastName;
                existingContact.Email = contact.Email;
                existingContact.Phone = contact.Phone;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating contact: {ex.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine("UpdateContact method execution finished.");
            }
        }

    }

}
