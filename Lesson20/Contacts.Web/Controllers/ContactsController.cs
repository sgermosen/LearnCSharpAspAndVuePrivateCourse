using Contacts.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Web.Controllers
{
    public class ContactsController : Controller
    {
        //private readonly IContactRepository _contactRepository;
        //private readonly ApplicationContext _context;
        //private readonly ContactAdoRepository _contactAdoRepository;
        //public ContactsController(ApplicationContext context, IContactRepository contactRepository, ContactAdoRepository contactAdoRepository)
        //{
        //    _contactRepository = contactRepository;
        //    _context = context;
        //    _contactAdoRepository = contactAdoRepository;
        //}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            // Pasar el id al modelo para ser utilizado en la vista
            return View(new Contact { ContactId = id });
        }

        public IActionResult Delete(int id)
        {
            // Pasar el id al modelo para ser utilizado en la vista
            return View(new Contact { ContactId = id });
        }
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    //var cotacts = _context.Contacts.ToList();
        //    var cotacts2 = _contactRepository.GetAll();
        //    return View(cotacts2);
        //}

        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Contact model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    _contactRepository.Add(model);
        //    return RedirectToAction("Index");
        //}

        //public IActionResult Edit(int id)
        //{
        //    var contactFromDb = _contactRepository.GetById(id);
        //    if (contactFromDb == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(contactFromDb);
        //}

        //[HttpPost]
        //public IActionResult Edit(Contact model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }
        //    //_context.Update(model);
        //    //_context.SaveChanges();
        //    _contactRepository.Update(model);
        //    return RedirectToAction("Index");
        //}


        //public IActionResult Delete(int id)
        //{
        //    var contactFromDb = _contactRepository.GetById(id);
        //    if (contactFromDb == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(contactFromDb);
        //}

        //[HttpPost]
        //public IActionResult Delete(Contact model)
        //{
        //    _contactRepository.Delete(model.ContactId);
        //    return RedirectToAction("Index");
        //}


    }
}
