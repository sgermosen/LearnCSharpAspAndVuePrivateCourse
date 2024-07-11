using AutoMapper;
using Contacts.Api.Dtos.Contacts;
using Contacts.Api.Helpers;
using Contacts.Api.Responses;
using Contacts.Application.Contracts;
using Contacts.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository _context;

        private readonly IMapper _mapper;

        public ContactsController(IContactRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetContacts")]
        public ContactResponse Get()
        {
            //var response = new ContactResponse();
            //response.Message = "Todo Bien";
            //var contactsFromDb = _context.GetAll();
            //var contactsToReturn = new List<ContactDto>();
            //foreach (var contact in contactsFromDb)
            //{
            //    //contactsToReturn.Add(new ContactDto
            //    //{
            //    //    Email = contact.Email,
            //    //    Phone = contact.Phone,
            //    //    Name = contact.Name,
            //    //    Address = contact.Address,
            //    //    Age = contact.Age,
            //    //    LastName = contact.LastName
            //    //});
            //    contactsToReturn.Add(ContactHelper.ToContactDto(contact));
            //}
            //response.Contacts = contactsToReturn;
            //return response;
            var contactsFromDb = _context.GetAll();
            var contactsToReturn = _mapper.Map<List<ContactDto>>(contactsFromDb);
            return new ContactResponse { Contacts = contactsToReturn, Message = "Todo Bien" };

        }

        [HttpGet("{id}", Name = "GetContact")]
        public ActionResult<Contact> Get(int id)
        {
            //var contactFromDb = _context.GetById(id);
            //if (contactFromDb == null)
            //{
            //    return NotFound("Contact not found");
            //}
            //return Ok(contactFromDb);

            var contactFromDb = _context.GetById(id);
            if (contactFromDb == null)
            {
                return NotFound("Contact not found");
            }
            var contactToReturn = _mapper.Map<ContactDto>(contactFromDb);
            return Ok(contactToReturn);
        }

        [HttpPost(Name = "CreateContact")]
        public async Task<IActionResult> Create([FromBody] CreateContactDto model)
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
                //    Name = model.Name,
                //    Address = model.Address,
                //    Age = model.Age,
                //    LastName = model.LastName,
                //    SexId = 1
                //};
                //var contactDb = ContactHelper.ToContact(model);
                //_context.Add(contactDb);
                //model.ContactId = contactDb.ContactId;
                //return CreatedAtRoute("GetContact", new { id = contactDb.ContactId }, model);
                var contactToCreate = _mapper.Map<Contact>(model);
                _context.Add(contactToCreate);
                 var contactToReturn = _mapper.Map<ContactDto>(contactToCreate);
                model.ContactId = contactToCreate.ContactId;
                return CreatedAtRoute("GetContact", new { id = contactToCreate.ContactId }, model);

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
                //_context.Update(model);
                //return Ok(model);
                var contactToUpdate = _mapper.Map<Contact>(model);
                _context.Update(contactToUpdate);
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
