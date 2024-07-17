namespace Contacts.Api.Dtos.Appointments
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int ContactId { get; set; }
    }

}
