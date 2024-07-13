namespace Contacts.Api.Controllers
{
    using Contacts.Application.Contracts;
    using Contacts.Domain;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IRepository<Appointment> _appointmentRepository;

        public AppointmentsController(IRepository<Appointment> appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appointment>>> GetAppointments()
        {
            var appointments = await _appointmentRepository.GetAll();
            return Ok(appointments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Appointment>> GetAppointment(int id)
        {
            var appointment = await _appointmentRepository.GetById(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return Ok(appointment);
        }

        [HttpPost]
        public async Task<ActionResult<Appointment>> PostAppointment(Appointment appointment)
        {
            await _appointmentRepository.Add(appointment);
            return CreatedAtAction(nameof(GetAppointment), new { id = appointment.Id }, appointment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppointment(int id, Appointment appointment)
        {
            if (id != appointment.Id)
            {
                return BadRequest();
            }

            await _appointmentRepository.Update(appointment);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            var appointment = await _appointmentRepository.GetById(id);
            if (appointment == null)
            {
                return NotFound();
            }

            await _appointmentRepository.Delete(id);
            return NoContent();
        }
    }

}
