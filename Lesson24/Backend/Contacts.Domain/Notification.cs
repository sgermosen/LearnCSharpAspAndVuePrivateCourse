using Contacts.Domain.Core;

namespace Contacts.Domain
{
    public class Notification : BaseEntity
    {
        public string Message { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }

}
