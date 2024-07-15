using Contacts.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Web.Controllers
{
    public class ContactsController : Controller
    { 
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
            return View(new Contact { Id = id });
        }

        public IActionResult Delete(int id)
        { 
            return View();
        }
          

    }
}
