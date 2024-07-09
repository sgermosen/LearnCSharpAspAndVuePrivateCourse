using Microsoft.AspNetCore.Mvc;
using ProgramsForLearning.Program14.Context;
using ProgramsForLearning.Program14.Contracts;
using ProgramsForLearning.Program14.Repositories;
using ProgramsForLearning.Program18.Models;
using System.Diagnostics;

namespace ProgramsForLearning.Program18.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactRepository _contactRepository;
        private readonly ApplicationContext _context;
        public ContactsController(ApplicationContext context, IContactRepository contactRepository )
        {
            _contactRepository = contactRepository;
            _context = context;
        }

        public IActionResult Index()
        {
            //var cotacts = _context.Contacts.ToList();
            var cotacts2 = _contactRepository.GetAll();
            return View(cotacts2);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
