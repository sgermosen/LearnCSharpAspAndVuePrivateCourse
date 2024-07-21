using Contacts.Domain;

namespace Contacts.Api.Responses
{
    public class AppointmentResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
        public int Code { get; set; }
        public List<Appointment> Data { get; set; }
    }
}
