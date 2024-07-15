using Contacts.Api.Dtos.Contacts;

namespace Contacts.Api.Responses
{
    public class ContactResponse
    {
        public string Message { get; set; }
        public List<ContactDto> Contacts { get; set; }
    }
}
