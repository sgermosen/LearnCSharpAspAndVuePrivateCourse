/*

Escriba un programa que realice las siguientes tareas:
1.	Implemente una clase Appointment con propiedades básicas.
2.	Cree una interfaz IAppointmentRepository y una clase AppointmentRepository que implemente esta interfaz.
3.	Implemente una clase genérica GenericRepository y una clase GenericAppointmentRepository que extienda GenericRepository.
4.	Utilice la clase JsonHelper para serializar y deserializar un objeto Appointment.
5.	Utilice la clase XmlHelper para serializar y deserializar un objeto Appointment.
Escriba un programa que realice las siguientes tareas:
1.	Cree una lista genérica de objetos anónimos que represente una colección de libros. Cada libro debe tener un Title y un Author.
2.	Agregue al menos 3 libros a la lista.
3.	Itere sobre la lista e imprima la información de cada libro.
4.	Cree una lista genérica de enteros y realice las siguientes operaciones: agregue 5 números, elimine uno de ellos, inserte un nuevo número en la segunda posición y busque un número específico en la lista.

 */


using ProgramsForLearning.HomeWork9.Helpers;
using ProgramsForLearning.HomeWork9.Models;
using ProgramsForLearning.HomeWork9.Repositories;

var appointmentRepo = new GenericRepository<Appointment>();
var appointment = new Appointment { Id = 1, Date = DateTime.Now, Description = "Doctor's appointment" };

appointmentRepo.Add(appointment);
var retrievedAppointment = appointmentRepo.GetById(1);
Console.WriteLine($"Appointment on {retrievedAppointment.Date}: {retrievedAppointment.Description}");

var json = JsonHelper.Serialize(retrievedAppointment);
Console.WriteLine($"Serialized to JSON: {json}");

var xml = XmlHelper.Serialize(retrievedAppointment);
Console.WriteLine($"Serialized to XML: {xml}");

appointmentRepo.Remove(appointment);

// Crear una lista genérica de objetos anónimos que representen libros
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

