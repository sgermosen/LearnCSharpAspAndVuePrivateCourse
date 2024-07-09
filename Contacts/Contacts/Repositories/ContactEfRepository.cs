using Contacts.Application.Contracts;
using Contacts.Domain;
using Contacts.Persistence;
namespace Contacts.Infraestructure.Repositories
{
    public class ContactEfRepository : IContactRepository
    {
        private readonly ApplicationContext _context;
        public ContactEfRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var contactFromDb = GetById(id);
            if (contactFromDb != null)
            {
                _context.Remove(contactFromDb);
                _context.SaveChanges();
            }
        }

        public Contact GetById(int id)
        {
            // var contactFromDb = _context.Contacts.FirstOrDefault(x => x.Id == id);
            //if (contactFromDb == null)
            //{
            //    return null;
            //}
            //return contactFromDb;
            return _context.Contacts.FirstOrDefault(x => x.ContactId == id);

        }

        public List<Contact> GetAll()
        {
            return _context.Contacts.ToList();

        }

        public void Update(Contact contact)
        {
            var contactFromDb = GetById(contact.ContactId);
            if (contactFromDb != null)
            {
                contactFromDb.Email = contact.Email;
                contactFromDb.Phone = contact.Phone;

                _context.Contacts.Update(contactFromDb);
                _context.SaveChanges();
            }
            throw new ArgumentNullException("Contact Not Found");
            //_context.Contacts.Update(contact);
            //_context.SaveChanges();

        }
    }
}
