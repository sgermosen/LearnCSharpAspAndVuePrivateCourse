namespace Contacts.Api.Dtos.Notifications
{

    public class NotificationDto
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int ContactId { get; set; }
    }

}
