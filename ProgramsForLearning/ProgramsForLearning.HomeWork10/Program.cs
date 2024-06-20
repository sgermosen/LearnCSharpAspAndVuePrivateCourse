/*
 
 Escriba un programa que realice las siguientes tareas:
•	Cree una lista genérica de objetos anónimos que represente una colección de libros. Cada libro debe tener un Title y un Author.
•	Agregue al menos 3 libros a la lista.
•	Itere sobre la lista e imprima la información de cada libro.
•	Cree una lista genérica de enteros y realice las siguientes operaciones: agregue 5 números, elimine uno de ellos, inserte un nuevo número en la segunda posición y busque un número específico en la lista.
Escriba un programa que realice las siguientes tareas:

•  Implemente una lista de contactos y añada métodos para agregar, eliminar, y listar contactos.
•  Cree un método que devuelva contactos utilizando tipos de datos anónimos.
•  Implemente un Dictionary para almacenar y buscar contactos por su ID.
•  Utilice LINQ para filtrar y ordenar los contactos por diferentes criterios.

 
 */


// Crear una lista genérica de objetos anónimos que representen libros
using ProgramsForLearning.HomeWork10;

var books = new List<object>
            {
                new { Title = "C# Programming", Author = "Alice" },
                new { Title = "Learning LINQ", Author = "Bob" },
                new { Title = "Mastering .NET", Author = "Charlie" }
            };

// Iterar sobre la lista e imprimir la información de cada libro
foreach (var book in books)
{
    Console.WriteLine("Title: " + book.GetType().GetProperty("Title").GetValue(book, null));
    Console.WriteLine("Author: " + book.GetType().GetProperty("Author").GetValue(book, null));
    Console.WriteLine();
}

// Crear una lista genérica de enteros
List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

// Agregar un número a la lista
numbers.Add(60);

// Eliminar un número de la lista
numbers.Remove(30);

// Insertar un número en la segunda posición
numbers.Insert(1, 25);

// Buscar un número específico en la lista
if (numbers.Contains(20))
{
    Console.WriteLine("The list contains the number 20.");
}

// Iterar sobre la lista e imprimir los elementos
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
////////////////////////////////
///

var contactManager = new ContactManager();
contactManager.AddContact(new Contact { Id = 1, Name = "John", LastName = "Doe", Email = "john@example.com", Phone = "123-456-7890" });
contactManager.AddContact(new Contact { Id = 2, Name = "Jane", LastName = "Smith", Email = "jane@example.com", Phone= "987-654-3210" });

var tempanonymousContacts = contactManager.ListContacts().Select(c => new { FullName = $"{c.Name} {c.LastName}", c.Email });
foreach (var ac in tempanonymousContacts)
{
    //dynamic contactAc = ac;
    Console.WriteLine($"Anonymous Contact: {ac.FullName}, Email: {ac.Email}");
}
var anonymousContacts = contactManager.ListContactsAsAnonymous();
foreach (var ac in anonymousContacts)
{
    //dynamic contactAc = ac;
    Console.WriteLine($"Anonymous Contact: {ac.FullName}, Email: {ac.Email}");
}

var contact = contactManager.GetContactById(1);
Console.WriteLine($"Contact by ID: {contact.Name} {contact.LastName}");

var filteredContacts = contactManager.FilterContactsByLastName("Doe");
foreach (var c in filteredContacts)
{
    Console.WriteLine($"Filtered Contact: {c.Name} {c.LastName}");
}

contactManager.SortContactsByFirstName();
var sortedContacts = contactManager.ListContacts();
foreach (var c in sortedContacts)
{
    Console.WriteLine($"Sorted Contact: {c.Name} {c.LastName}");
}


