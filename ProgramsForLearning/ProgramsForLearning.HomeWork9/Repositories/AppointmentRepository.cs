using ProgramsForLearning.HomeWork9.Contracts;
using ProgramsForLearning.HomeWork9.Models;

namespace ProgramsForLearning.HomeWork9.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly List<Appointment> _appointments = new List<Appointment>();

        public void Add(Appointment appointment)
        {
            _appointments.Add(appointment);
        }

        public void Update(Appointment appointment)
        {
            var existingAppointment = GetById(appointment.Id);
            if (existingAppointment != null)
            {
                existingAppointment.Date = appointment.Date;
                existingAppointment.Description = appointment.Description;
            }
        }

        public void Delete(int appointmentId)
        {
            var appointment = GetById(appointmentId);
            if (appointment != null)
            {
                _appointments.Remove(appointment);
            }
        }

        public Appointment GetById(int appointmentId)
        {
            return _appointments.FirstOrDefault(a => a.Id == appointmentId);
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _appointments;
        }
    }

}
