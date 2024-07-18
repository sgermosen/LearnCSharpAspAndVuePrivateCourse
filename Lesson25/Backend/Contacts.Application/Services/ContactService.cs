using Contacts.Application.Contracts;
using Contacts.Application.Dtos.Contacts;
using Contacts.Domain;

namespace Contacts.Application.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<List<Contact>> GetAllContactsAsync()
        {
            return await _contactRepository.GetAll();
        }

        public async Task<Contact> GetContactByIdAsync(int id)
        {
            return await _contactRepository.GetByIdNoTrackeable(id);
        }

        public async Task AddContactAsync(Contact contact)
        {
            await _contactRepository.Add(contact);
        }

        public async Task UpdateContactAsync(UpdateContactDto contact)
        {
            var contactDb = await _contactRepository.GetById(contact.ContactId);

            contactDb.Phone = contact.Phone;
            contactDb.LastName = contact.LastName;
            contactDb.Name = contact.Name;

            await _contactRepository.Update(contactDb);
        }

        public async Task DeleteContactAsync(int id)
        {
            await _contactRepository.Delete(id);
        }

        public async Task<List<Contact>> GetContactsWithAppointmentsAsync()
        {
            return await _contactRepository.GetContactsWithAppointments();
        }

        public async Task<List<Contact>> GetContactsWithNotificationsAsync()
        {
            return await _contactRepository.GetContactsWithNotifications();
        }
        public async Task<List<Contact>> GetContactsWithNotificationsAndAppointmentsAsync()
        {
            return await _contactRepository.GetContactsWithNotificationsAndAppointments();
        }
    }

}
