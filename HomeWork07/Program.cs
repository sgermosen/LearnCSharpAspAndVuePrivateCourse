/*
 Escriba un programa que realice las siguientes tareas:
o	Implemente una clase Contact con propiedades y métodos auto-implementados.
o	Cree una clase Reminder que herede de Contact y añada propiedades específicas para los recordatorios.
o	Sobrecargue un método en la clase Reminder para añadir múltiples recordatorios de diferentes tipos.
o	Cree un método estático en una clase Notification para enviar notificaciones de recordatorios.
Escriba un programa que realice las siguientes tareas:
o	Defina una clase llamada Shape con un método virtual GetArea.
o	Cree dos clases derivadas, Circle y Rectangle, que sobrescriban el método GetArea para calcular el área del círculo y del rectángulo, respectivamente.
o	En el método Main, cree objetos de las clases Circle y Rectangle, asigne valores a sus propiedades, y llame al método GetArea para mostrar el área de cada figura.
o	Sobrecargue el método GetArea en la clase Rectangle para permitir el cálculo del área con diferentes unidades (p. ej., cm², m²).

 */

using ProgramsForLearning.HomeWork7;

var contact = new Contact
{
    FirstName = "John",
    LastName = "Doe",
    Email = "john.doe@example.com",
    PhoneNumber = "123-456-7890"
};

var reminder = new Reminder
{
    FirstName = "John",
    LastName = "Doe",
    Email = "john.doe@example.com",
    PhoneNumber = "123-456-7890",
    ReminderDate = new DateTime(2023, 12, 1),
    Message = "Doctor's Appointment"
};

reminder.DisplayContactInfo();
reminder.DisplayReminderInfo();

Notification.SendNotification(reminder);

// Crear un objeto de la clase Circle 
Circle circle = new Circle { Radius = 5 };
Console.WriteLine("Area of the circle: " + circle.GetArea());

// Crear un objeto de la clase Rectangle
Rectangle rectangle = new Rectangle { Width = 10, Height = 20 };
Console.WriteLine("Area of the rectangle: " + rectangle.GetArea());
Console.WriteLine("Area of the rectangle in m²: " + rectangle.GetArea("m"));
