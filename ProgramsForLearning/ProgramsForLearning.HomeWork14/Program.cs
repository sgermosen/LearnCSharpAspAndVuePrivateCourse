/*
 
•	Implemente la interfaz IContactRepository y la clase ContactRepository usando ADO.NET.
•	Cree métodos en ContactRepository para agregar, actualizar, eliminar y recuperar contactos usando ADO.NET.
•	Utilice transacciones para asegurar la integridad de los datos durante las operaciones de agregar y actualizar contactos.

•	Configure Entity Framework en un nuevo proyecto utilizando los paquetes necesarios.
•	Defina una entidad Contact y un contexto ContactDbContext.
•	Implemente el repositorio ContactRepository usando Entity Framework.
•	Cree y aplique migraciones para la base de datos.
•	Realice operaciones CRUD utilizando el repositorio con EF.

 
 */

using Microsoft.EntityFrameworkCore;
using ProgramsForLearning.HomeWork14.Context;
using ProgramsForLearning.HomeWork14.Contracts;
using ProgramsForLearning.HomeWork14.Models;
using ProgramsForLearning.HomeWork14.Repositories;
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

