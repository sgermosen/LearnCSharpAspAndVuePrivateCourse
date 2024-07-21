namespace Contacts.Api.Requests.Contacts
{
    public class CreateContactRequest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
