using ProgramsForLearning.Program10.Models;
using ProgramsForLearning.Program10.Services;

var contactManager = new ContactManager();


var contact = new Contact
{
    Id = 1,
    Address = "Calle Luna",
    Age = 15,
    Email = "email@email.com",
    LastName = "Roger",
    Name = "Zapata",
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

var contact3 = new Contact
{
    Id = 3,
    Address = "Calle Parcha",
    Age = 20,
    Email = "email3@email.com",
    LastName = "Carmelita",
    Name = "Trinidad",
    Phone = "512454555"
};

contactManager.AddContact(contact);
contactManager.AddContact(contact2);
contactManager.AddContact(contact3);

var contacts = contactManager.GetContacts();

foreach (var item in contacts)
{
    Console.WriteLine($" Nombre:{item.Name} Apellido: {item.LastName}");
}

var contactsSorted = contactManager.GetContacts().OrderBy(p => p.Name);

foreach (var item in contactsSorted)
{
    Console.WriteLine($" Nombre:{item.Name} Apellido: {item.LastName}");
}

var contactsSortedDecendingInManager = contactManager.GetContactsSortedByName();

foreach (var contactItem in contactsSortedDecendingInManager)
{
    Console.WriteLine($" Nombre:{contactItem.Name} Apellido: {contactItem.LastName}");
}



var contacts2 = new List<Contact>
{
    new Contact  {  Id = 1,  Address = "Calle Parcha",  Age = 20,  Email = "email3@email.com",  LastName = "Castillo",   Name = "Gonzalo", Phone = "512454555"},
    new Contact
    {
        Id = 2,
        Address = "Calle Sol",
        Age = 20,
        Email = "email2@email.com",
        LastName = "Carramillo",
        Name = "Leonel",
        Phone = "512454555"
    },
    new Contact
    {
        Id = 3,
        Address = "Calle Luna",
        Age = 15,
        Email = "email@email.com",
        LastName = "Leon",
        Name = "Danilo",
        Phone = "512454855"
    }
};

contactManager.AddContacts(contacts2);



var anonimousContacts = contactsSorted.Select(c => new
{
    FullName = $"{c.Name} {c.LastName}",
    AditionalInfo = 1,
    Name = c.Name,
    Phone = c.Phone,
    c.Email
});



foreach (var item in anonimousContacts)
{
    Console.WriteLine($"Nombre Completo: {item.FullName}, Informacion adicional: {item.AditionalInfo}, Tel: {item.Phone}, Email: {item.Email}");
}

var anonimousContacts2 = contactsSorted.Select(c => new ContactViewModel
{
    FullName = $"{c.Name} {c.LastName}",
    AditionalInfo = 1.ToString(),
    Name = c.Name,
    Phone = c.Phone,
    Email = c.Email
});

foreach (var item in anonimousContacts)
{
    Console.WriteLine($"Nombre Completo: {item.FullName}, Informacion adicional: {item.AditionalInfo}, Tel: {item.Phone}, Email: {item.Email}");
}



var contacts3 = new Dictionary<int, Contact>
{
    { 1,  new Contact  {  Id = 1,  Address = "Calle Parcha",  Age = 20,  Email = "email3@email.com",  LastName = "Castillo",   Name = "Gonzalo", Phone = "512454555"} },
    { 2, new Contact { Id = 2,  Address = "Calle Sol",  Age = 20, Email = "email2@email.com", LastName = "Carramillo",  Name = "Leonel",  Phone = "512454555" }},
    { 3, new Contact  {  Id = 3,  Address = "Calle Luna", Age = 15,  Email = "email@email.com",  LastName = "Leon",   Name = "Danilo",     Phone = "512454855"  }}
};


//Dictionary<int, Contact> contacts3 = new Dictionary<int, Contact>();
var findedContactInDictionary = contacts3[contact.Id];
Contact contactTemp;
if (findedContactInDictionary == null)
{
    contacts3.Add(contact.Id, contact);
}
if (contacts3.TryGetValue(contact.Id, out contactTemp))
{
    //if (contactTemp == null)
    //{
    //    contacts3.Add(contact.Id, contact);
    //}
    //else {
    //    contacts3.Remove(contact.Id);
    //    contacts3.Add(contact.Id, contact); 
    //}
    if (contactTemp != null)
    {
        //contacts3.Remove(contact.Id);
        contact.Id = contacts3.Count + 1;
    }

    contacts3.Add(contact.Id, contact);

}
 
contacts3.Add(contact2.Id, contact2);
contacts3.Add(contact3.Id, contact3);
 
foreach (var item in contacts3.Values)
{
    Console.WriteLine($"Tel: {item.Phone}, Email: {item.Email}"); 
}