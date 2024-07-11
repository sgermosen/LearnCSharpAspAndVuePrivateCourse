namespace ProgramsForLearning.HomeWork7
{
    public static class Notification
    {
        public static void SendNotification(Reminder reminder)
        {
            Console.WriteLine($"Sending notification: {reminder.Message} on {reminder.ReminderDate}");
        }
    }

}
