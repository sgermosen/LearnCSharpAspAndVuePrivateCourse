namespace Contacts.Api.Requests.Contacts
{
    public class UpdateContactRequest
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
