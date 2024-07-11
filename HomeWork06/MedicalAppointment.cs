namespace ProgramsForLearning.HomeWork6
{
    public class MedicalAppointment : Person
    {
        public DateTime AppointmentDate { get; set; }
        public string DoctorName { get; set; }

        public void DisplayAppointmentDetails()
        {
            Console.WriteLine($"Appointment with Dr. {DoctorName} on {AppointmentDate}");
        }
    }

}
