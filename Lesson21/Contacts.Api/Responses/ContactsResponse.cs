using Contacts.Domain;

namespace Contacts.Api.Responses
{
    public class ContactsResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
        public int Code { get; set; }
        public List<Contact> Data { get; set; }
    }
}
