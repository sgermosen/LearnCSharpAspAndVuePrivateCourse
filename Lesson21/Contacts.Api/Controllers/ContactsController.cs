using AutoMapper;
using Contacts.Api.Dtos.Contacts;
using Contacts.Api.Helpers;
using Contacts.Api.Requests.Contacts;
 
using Contacts.Application.Contracts;
using Contacts.Application.Responses;
using Contacts.Application.Responses.Contacts;
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
       // private readonly ApplicationContext _context;

        public ContactsController(IContactService contacService, IMapper mapper)//, ApplicationContext context)
        {
            _contactService = contacService;
            _mapper = mapper;
          //  this._context = context;
        }

        [HttpGet(Name = "GetContacts")]
        public async Task<Response<List<ContactResponse>>> GetAsync()
        {
            //var response = new ContactResponse();
            //response.Message = "Todo Bien";
            //var contactsFromDb = _context.GetAll();
            var contactsInDb = await  _contactService.GetAllContacts(); // _context.Contacts.ToList();
            if (!contactsInDb.Any())
            {
                return new Response<List<ContactResponse>>
                {
                    Code = 404,
                    Error = "No se encontró registro",
                    Success = false
                };
            }

            var contactsToReturn = new List<ContactResponse>();
            foreach (var contact in contactsInDb)
            {
                //contactsToReturn.Add(new ContactResponse
                //{
                //    Email = contact.Email,
                //    Phone = contact.Phone,
                //    Name = contact.Name,
                //    Address = contact.Address,
                //    Age = contact.Age,
                //    LastName = contact.LastName
                //});
                contactsToReturn.Add(ContactHelper.ToContactContactResponse(contact));
            }
            //response.Contacts = contactsToReturn;
            //return response;

            return new Response<List<ContactResponse>>
            {
                Code = 200,
                Data = contactsToReturn,
                Message = "Todo bien",
                Success = true
            };


            //return new Responses<Contact>
            //{
            //    Code = 200,
            //    Data = contactsInDb,
            //    Message = "Todo bien",
            //    Success = true
            //};

            //var contactsFromDb = await _contactService.GetAllContacts();
            //var contactsToReturn = _mapper.Map<List<ContactDto>>(contactsFromDb);
            //return new ContactResponse { Contacts = contactsToReturn, Message = "Todo Bien" };

        }

        [HttpGet("{id}", Name = "GetContact")]
        public async Task<ActionResult<Response<ContactResponse>>> Get(int id)
        {

            return  await _contactService.GetContactById(id);

            //var contactFromDb = _context.GetById(id);
            //if (contactFromDb == null)
            //{
            //    return NotFound("Contact not found");
            //}
            //return Ok(contactFromDb);

            //  ContactResponse response;

            //var contactinDb = await  _contactService.GetContactById(id);// _context.Contacts.FirstOrDefault(x => x.Id == id);


            //if (contactinDb == null)
            //{
            //    return new Response<ContactResponse>
            //    {
            //        Code = 404,
            //        Error = "No se encontró registro",
            //        Success = false
            //    };
            //}

            //var contactResponse = new ContactResponse
            //{
            //    ContactId = contactinDb.Id,
            //    Email = contactinDb.Email,
            //    Phone = contactinDb.Phone,
            //    Name = contactinDb.Name,
            //    Address = contactinDb.Address,
            //    Age = contactinDb.Age,
            //    LastName = contactinDb.LastName
            //};
            //return new Response<ContactResponse>
            //{
            //    Code = 200,
            //    Data = contactResponse,
            //    Message = "Todo bien",
            //    Success = true
            //};


            //if (contactinDb == null)
            //{
            //    return new ContactResponse
            //    {
            //        Code = 404,
            //        Error = "No se encontró registro",
            //        Success = false
            //    };
            //}

            //return new ContactResponse
            //{
            //    Code = 200,
            //    Data = contactinDb,
            //    Message = "Todo bien",
            //    Success = true
            //};



            var contactFromDb = await _contactService.GetContactById(id);
            if (contactFromDb == null)
            {
                return NotFound("Contact not found");
            }
            var contactToReturn = _mapper.Map<ContactDto>(contactFromDb);
            return Ok(contactToReturn);
        }

        [HttpPost(Name = "CreateContact")]
        public async Task<ActionResult<Response<Contact>>> Create([FromBody] CreateContactRequest model)
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
                var contactDb = new Contact
                {
                    Email = model.Email,
                    Phone = model.Phone,
                    Name = model.Name,
                    Address = model.Address,
                    Age = model.Age,
                    LastName = model.LastName,
                    SexId = 1, 
                    IsFavorite =true
                };
                //var contactDb = ContactHelper.ToContact(model);
                //_context.Add(contactDb);
                //model.ContactId = contactDb.ContactId;
                //return CreatedAtRoute("GetContact", new { id = contactDb.ContactId }, model);

                //_context.Contacts.Add(contactDb);
                //_context.SaveChanges();
                await _contactService.AddContact(contactDb);
                //return Ok(model);

                return new Response<Contact>
                {
                    Code = 200,
                    Data = contactDb,
                    Message = "Todo bien",
                    Success = true
                };
                var contactToCreate = _mapper.Map<Contact>(model);
                _contactService.AddContact(contactToCreate);
                var contactToReturn = _mapper.Map<ContactDto>(contactToCreate);
                //model.ContactId = contactToCreate.Id;
                return CreatedAtRoute("GetContact", new { id = contactToCreate.Id }, model);

            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}", Name = "UpdateContact")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateContactRequest model)
        {
            if (model == null || id != model.ContactId)
            {
                return BadRequest("Contact data is invalid");
            }

            var contactFromDb = await _contactService.GetContactById(id);// _context.Contacts.Find(id);
            if (contactFromDb == null)
            {
                return NotFound("Contact not found");
            }

            //if (await _context.Contacts.AnyAsync(c => c.Email == model.Email && c.ContactId != id))
            //{
            //    return BadRequest("This email is already in use by another contact");
            //}

            if (ModelState.IsValid)
            {

                contactFromDb.Phone = model.Phone;
                contactFromDb.Name = model.Name;
                contactFromDb.LastName = model.LastName;
                contactFromDb.Address = model.Address;

                //_context.Contacts.Update(contactFromDb);
                //_context.SaveChanges();
                //await _context.SaveChangesAsync();
                //_context.Update(model);
               await  _contactService.UpdateContact(contactFromDb);
                return Ok(contactFromDb);


                var contactToUpdate = _mapper.Map<Contact>(model);
                _contactService.UpdateContact(contactToUpdate);
                return Ok(model);
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

            await _contactService.DeleteContact(contactFromDb.Id);
            return Ok("Contact Deleted");
        }
    }
}
