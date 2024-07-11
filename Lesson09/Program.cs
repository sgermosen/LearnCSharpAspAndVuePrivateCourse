

using ProgramsForLearning.Program9.Helpers;
using ProgramsForLearning.Program9.Models;
using ProgramsForLearning.Program9.Repositories;

//var contactRepository = new ContactRepository();
//var notificationRepository = new NotificationRepository();
var notificationRepository = new GenericRepository<Notification>();

var contactRepository2 = new GenericRepository<Contact>();

var contact = new Contact
{
    Id = 1,
    Address = "Calle Luna",
    Age = 15,
    Email = "email@email.com",
    LastName = "Roger",
    Name = "Albert",
    Phone = "512454855"
};

var contact2 = new Contact
{
    Id = 2,
    Address = "Calle Sol",
    Age = 20,
    Email = "email2@email.com",
    LastName = "Rogelia",
    Name = "Genao",
    Phone = "512454555"
};

//contactRepository.Add(contact);
//contactRepository.Add(contact2);
contactRepository2.Add(contact);
contactRepository2.Add(contact2);

//var contacts = contactRepository.GetAll();
var contacts = contactRepository2.GetAll();
Console.WriteLine($"La Cantidad de elementos es: {contacts.Count()}");

foreach (var item in contacts)
{
    Console.WriteLine($"El nombre es: {item.Name}");
}

//var contact2FromDb = contactRepository.GetById(2);
var contact2FromDb = contactRepository2.GetById(2);
contact2FromDb.Name = "Juancito";

//contactRepository.Update(contact2);
contactRepository2.Update(contact2FromDb);

contacts = contactRepository2.GetAll();
//contacts = contactRepository.GetAll();
Console.WriteLine($"La Cantidad de elementos es: {contacts.Count()}");

foreach (var item in contacts)
{
    Console.WriteLine($"El nombre es: {item.Name}");
}


//contactRepository.Delete(2);
contactRepository2.Delete(contact2FromDb);

//contacts = contactRepository.GetAll();
contacts = contactRepository2.GetAll();
Console.WriteLine($"La Cantidad de elementos es: {contacts.Count()}");

foreach (var item in contacts)
{
    Console.WriteLine($"El nombre es: {item.Name}");
}


string json = string.Empty;
json = JsonHelper.Serialize(contact);
Console.WriteLine(json);

var objectmine = JsonHelper.Deserialize<Contact>(json);

Console.WriteLine(objectmine);

