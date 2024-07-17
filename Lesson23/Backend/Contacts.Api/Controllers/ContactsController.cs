using AutoMapper;
using Contacts.Api.Responses;
using Contacts.Application.Contracts;
using Contacts.Application.Dtos.Contacts;
using Contacts.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        private readonly IMapper _mapper;

        public ContactsController(IContactService context, IMapper mapper)
        {
            _contactService = context;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetContacts")]
        public async Task<ContactResponse> Get()
        {
            var contactsFromDb = await _contactService.GetAllContacts();
            var contactsToReturn = _mapper.Map<List<ContactDto>>(contactsFromDb);
            return new ContactResponse { Contacts = contactsToReturn, Message = "Todo Bien" };

        }

        [HttpGet("{id}", Name = "GetContact")]
        public async Task<ActionResult<ContactDto>> Get(int id)
        {
            var contactFromDb = await _contactService.GetContactById(id);
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

            if (ModelState.IsValid)
            {
                var contactToCreate = _mapper.Map<Contact>(model);
                _contactService.AddContact(contactToCreate);
                var contactToReturn = _mapper.Map<ContactDto>(contactToCreate);
                model.ContactId = contactToCreate.Id;
                return CreatedAtRoute("GetContact", new { id = contactToCreate.Id }, model);

            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}", Name = "UpdateContact")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateContactDto model)
        {
            if (model == null || id != model.ContactId)
            {
                return BadRequest("Contact data is invalid");
            }

            if (ModelState.IsValid)
            {
                await _contactService.UpdateContact(model);

                var contactFromDb = _contactService.GetContactById(model.ContactId);
                var contatoReturn  = _mapper.Map<UpdateContactDto>(contactFromDb);
                return Ok(contatoReturn);
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}", Name = "DeleteContact")]
        public async Task<IActionResult> Delete(int id)
        {
            var contactFromDb = _contactService.GetContactById(id);
            if (contactFromDb == null)
            {
                return NotFound("Contact not found");
            }

            _contactService.DeleteContact(contactFromDb.Id);
            return Ok("Contact Deleted");
        }
    }
}
