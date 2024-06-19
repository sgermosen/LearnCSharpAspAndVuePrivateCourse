namespace ProgramsForLearning.HomeWork7
{
    public class Reminder : Contact
    {
        public DateTime ReminderDate { get; set; }
        public string Message { get; set; }

        public void DisplayReminderInfo()
        {
            Console.WriteLine($"Reminder for {FullName} on {ReminderDate}: {Message}");
        }

        public void SetReminder(DateTime date, string message)
        {
            ReminderDate = date;
            Message = message;
        }

        public void SetReminder(DateTime date, string message, string location)
        {
            ReminderDate = date;
            Message = $"{message} at {location}";
        }
    }

}
