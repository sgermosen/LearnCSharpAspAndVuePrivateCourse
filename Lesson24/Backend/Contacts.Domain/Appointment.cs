using Contacts.Domain.Core;

namespace Contacts.Domain
{
    public class Appointment : BaseEntity
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }

    }
}
