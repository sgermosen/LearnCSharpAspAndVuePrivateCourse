using System.ComponentModel.DataAnnotations;

namespace Contacts.Domain
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsFavorite { get; set; }
        public DateTime BornDate { get; set; }
        public decimal DebAmount { get; set; }
        public int SexId { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}
