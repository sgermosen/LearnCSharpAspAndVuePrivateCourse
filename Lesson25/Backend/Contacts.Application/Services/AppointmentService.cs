namespace Contacts.Application.Services
{
    using Contacts.Application.Contracts;
    using Contacts.Domain;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class AppointmentService : IAppointmentService
    {
        private readonly IRepository<Appointment> _appointmentRepository;

        public AppointmentService(IRepository<Appointment> appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task<IEnumerable<Appointment>> GetAllAppointments()
        {
            return await _appointmentRepository.GetAll();
        }

        public async Task<Appointment> GetAppointmentById(int id)
        {
            return await _appointmentRepository.GetById(id);
        }

        public async Task AddAppointment(Appointment appointment)
        {
            await _appointmentRepository.Add(appointment);
        }

        public async Task UpdateAppointment(Appointment appointment)
        {
            await _appointmentRepository.Update(appointment);
        }

        public async Task DeleteAppointment(int id)
        {
            await _appointmentRepository.Delete(id);
        }
    }

}
