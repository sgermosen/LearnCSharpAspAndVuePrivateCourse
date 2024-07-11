using ProgramsForLearning.HomeWork9.Models;

namespace ProgramsForLearning.HomeWork9.Contracts
{
    public interface IAppointmentRepository
    {
        void Add(Appointment appointment);
        void Update(Appointment appointment);
        void Delete(int appointmentId);
        Appointment GetById(int appointmentId);
        IEnumerable<Appointment> GetAll();
    }

}
