namespace Contacts.Api.Controllers
{
    using Contacts.Application.Contracts;
    using Contacts.Domain;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IRepository<Notification> _notificationRepository;

        public NotificationsController(IRepository<Notification> notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Notification>>> GetNotifications()
        {
            var notifications = await _notificationRepository.GetAll();
            return Ok(notifications);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Notification>> GetNotification(int id)
        {
            var notification = await _notificationRepository.GetById(id);
            if (notification == null)
            {
                return NotFound();
            }
            return Ok(notification);
        }

        [HttpPost]
        public async Task<ActionResult<Notification>> PostNotification(Notification notification)
        {
            await _notificationRepository.Add(notification);
            return CreatedAtAction(nameof(GetNotification), new { id = notification.Id }, notification);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutNotification(int id, Notification notification)
        {
            if (id != notification.Id)
            {
                return BadRequest();
            }

            await _notificationRepository.Update(notification);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotification(int id)
        {
            var notification = await _notificationRepository.GetById(id);
            if (notification == null)
            {
                return NotFound();
            }

            await _notificationRepository.Delete(id);
            return NoContent();
        }
    }

}
