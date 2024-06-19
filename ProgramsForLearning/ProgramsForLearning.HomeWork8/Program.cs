
/*
1.	Implemente una interfaz IContactManager para la gestión de contactos con métodos para agregar, actualizar, eliminar y listar contactos.
2.	Cree una clase ContactManager que implemente IContactManager.
3.	Implemente una interfaz INotificationService con un método para enviar notificaciones.
4.	Cree dos clases EmailNotificationService y SmsNotificationService que implementen INotificationService.
5.	Utilice la composición para crear un servicio de gestión de contactos que envíe notificaciones cuando se agregue un nuevo contacto.
 
 */
using ProgramsForLearning.HomeWork8.Contracts;
using ProgramsForLearning.HomeWork8.Models;
using ProgramsForLearning.HomeWork8.Services;

IContactManager contactManager = new ContactManager();
INotificationService emailNotificationService = new EmailNotificationService();
INotificationService smsNotificationService = new SmsNotificationService();
IContactManager contactMAnagerWithNotificationForEmail = new ContactManagerWithNotification(contactManager, emailNotificationService);
IContactManager contactMAnagerWithNotificationForsms = new ContactManagerWithNotification(contactManager, smsNotificationService);


//homework 8.2 
//Hacer que lo que estamos haciendo acá se realice por peticion al usuario

int choise = 1;


if (choise == 1)
{
    var name = "Albert";
    var lastName = "Roger";
}
var contact = new Contact
{
    Address = "Calle Luna",
    Age = 15,
    Email = "email@email.com",
    LastName = "Roger",
    Name = "Albert",
    Phone = "512454855"
};
contactMAnagerWithNotificationForEmail.AddContact(contact);


var contact2 = new Contact
{
    Address = "Calle Sol",
    Age = 20,
    Email = "email2@email.com",
    LastName = "Rogelia",
    Name = "Genao",
    Phone = "512454555"
};
contactMAnagerWithNotificationForEmail.AddContact(contact2);

var contacts = contactMAnagerWithNotificationForEmail.ListContacts();

Console.WriteLine($"La Cantidad de elementos es: {contacts.Count()}");

foreach (var item in contacts)
{
    Console.WriteLine($"El nombre es: {item.Name}");
}

//var findedContact = contacts.Where(p => p.Id == 2).FirstOrDefault();
//findedContact.Name = "Calle";
//contactMAnagerWithNotificationForEmail.UpdateContact(findedContact);

foreach (var item in contacts)
{
    if (item.Id == 2)
    {
        item.Name = "Calle";
        contactMAnagerWithNotificationForEmail.UpdateContact(item);
        break;
    }
}
contacts = contactMAnagerWithNotificationForEmail.ListContacts();
Console.WriteLine($"La Cantidad de elementos es: {contacts.Count()}");

foreach (var item in contacts)
{
    Console.WriteLine($"El nombre es: {item.Name}");
}
foreach (var item in contacts)
{
    if (item.Id == 2)
    {
        contactMAnagerWithNotificationForEmail.DeleteContact(item.Id);
        break;
    }
}
contacts = contactMAnagerWithNotificationForEmail.ListContacts();
Console.WriteLine($"La Cantidad de elementos es: {contacts.Count()}");

foreach (var item in contacts)
{
    Console.WriteLine($"El nombre es: {item.Name}");
}




