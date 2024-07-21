using Azure.Core;
using Contacts.Api.Dtos.Contacts;
using Contacts.Api.Requests.Contacts;
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
        public static ContactResponse ToContactContactResponse(Contact contact)
        {
            return new ContactResponse
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
            //return new Contact
            //{
            //    Email = dto.Email,
            //    Phone = dto.Phone,
            //    Name = dto.Name,
            //    Address = dto.Address,
            //    Age = dto.Age,
            //    LastName = dto.LastName
            //};
            return CreateContact(dto.Name, dto.LastName, dto.Address, dto.Email, dto.Phone, dto.Age);

        }
        public static Contact ToContact(CreateContactDto dto)
        {
            //return new Contact
            //{
            //    Email = dto.Email,
            //    Phone = dto.Phone,
            //    Name = dto.Name,
            //    Address = dto.Address,
            //    Age = dto.Age,
            //    LastName = dto.LastName
            //};
            return CreateContact(dto.Name, dto.LastName, dto.Address, dto.Email, dto.Phone, dto.Age);

        }
        public static Contact ToContact(CreateContactRequest request)
        {
            return CreateContact(request.Name, request.LastName, request.Address, request.Email, request.Phone, request.Age);
        }

        private static Contact CreateContact(string name, string lastName, string address, string email, string phone,  int age)
        {

            return new Contact
            {
                Email = email,
                Phone = phone,
                Name = name,
                Address = address,
                Age = age,
                LastName = lastName
            };
        }
    }
}
