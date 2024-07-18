using Contacts.Application.Dtos.Contacts;
using Contacts.Domain;

namespace Contacts.Api.Helpers
{
    public static class ContactHelper
    {
        public static ContactDto ToContactDto(Contact contact)
        {
            return new ContactDto
            {
                Email = contact.Email,
                Phone = contact.Phone,
                Name = contact.Name,
                Address = contact.Address,
                Age = contact.Age,
                LastName = contact.LastName,
                ContactId = contact.Id
            };
        }
        public static Contact ToContact(ContactDto dto)
        {
            return new Contact
            {
                Email = dto.Email,
                Phone = dto.Phone,
                Name = dto.Name,
                Address = dto.Address,
                Age = dto.Age,
                LastName = dto.LastName
            };
        }
        public static Contact ToContact(CreateContactDto dto)
        {
            return new Contact
            {
                Email = dto.Email,
                Phone = dto.Phone,
                Name = dto.Name,
                Address = dto.Address,
                Age = dto.Age,
                LastName = dto.LastName
            };
        }
    }
}
