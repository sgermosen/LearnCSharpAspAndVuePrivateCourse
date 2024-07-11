

using Microsoft.EntityFrameworkCore;
using ProgramsForLearning.Program14.Context;
using ProgramsForLearning.Program14.Contracts;
using ProgramsForLearning.Program14.Models;
using ProgramsForLearning.Program14.Repositories;
using System.Configuration;



var options = new DbContextOptionsBuilder<ApplicationContext>()
    .UseSqlServer(ConfigurationManager.ConnectionStrings["ContactesDbCnn"].ConnectionString)
    .Options;

var context = new ApplicationContext(options);

IContactRepository contactRepository = new ContactEfRepository(context);

var newContact = new Contact
{
    ContactId = 1000001,
    Name = "John",
    LastName = "Doe",
    Email = "john.doe@example.com",
    Phone = "123-456-7890"
};

contactRepository.Add(newContact);

var contact = contactRepository.GetById(1000001);
Console.WriteLine($"Contact retrieved: {contact.Name} {contact.LastName}");

newContact.Email = "john.doe@newemail.com";
contactRepository.Update(newContact);
Console.WriteLine("Contact updated.");

var contacts = contactRepository.GetAll();
foreach (var c in contacts)
{
    Console.WriteLine($"{c.Name} {c.LastName}");
}

contactRepository.Delete(1000001);
Console.WriteLine("Contact deleted.");

