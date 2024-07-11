using Contacts.Application.Contracts;
using Contacts.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository _context;

        public ContactsController(IContactRepository context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetContacts")]
        public IEnumerable<Contact> Get()
        {
            var contactsFromDb = _context.GetAll();
            return contactsFromDb;
        }

        [HttpGet("{id}", Name = "GetContact")]
        public ActionResult<Contact> Get(int id)
        {
            var contactFromDb = _context.GetById(id);
            if (contactFromDb == null)
            {
                return NotFound("Contact not found");
            }
            return Ok(contactFromDb);
        }

        [HttpPost(Name = "CreateContact")]
        public async Task<IActionResult> Create([FromBody] Contact model)
        {
            if (model == null)
            {
                return BadRequest("Contact data is null");
            }

            //bool emailExists = await _context.Contacts
            //    .AnyAsync(c => c.Email == model.Email);
            //if (emailExists)
            //{
            //    return BadRequest("This email is already in use");
            //}

            if (ModelState.IsValid)
            {
                //var contactDb = new Contact
                //{
                //    Email = model.Email,
                //    Phone = model.Phone,
                //    Name = model.Name
                //};

                _context.Add(model);
                return CreatedAtRoute("GetContact", new { id = model.ContactId }, model);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}", Name = "UpdateContact")]
        public async Task<IActionResult> Update(int id, [FromBody] Contact model)
        {
            if (model == null || id != model.ContactId)
            {
                return BadRequest("Contact data is invalid");
            }

            //var contactFromDb =   _context.GetById(id);
            //if (contactFromDb == null)
            //{
            //    return NotFound("Contact not found");
            //}

            //if (await _context.Contacts.AnyAsync(c => c.Email == model.Email && c.ContactId != id))
            //{
            //    return BadRequest("This email is already in use by another contact");
            //}

            if (ModelState.IsValid)
            {
                //contactFromDb.Email = model.Email;
                //contactFromDb.Phone = model.Phone;
                //contactFromDb.Name = model.Name;

                //_context.Contacts.Update(contactFromDb);
                //await _context.SaveChangesAsync();
                _context.Update(model);
                return Ok(model);
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}", Name = "DeleteContact")]
        public async Task<IActionResult> Delete(int id)
        {
            var contactFromDb = _context.GetById(id);
            if (contactFromDb == null)
            {
                return NotFound("Contact not found");
            }

            _context.Delete(contactFromDb.ContactId);
            return Ok("Contact Deleted");
        }
    }
}
