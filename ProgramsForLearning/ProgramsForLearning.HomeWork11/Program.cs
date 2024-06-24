/* 
 * 
 * 
 * 

1.	Escriba un programa que realice las siguientes tareas:
o	Solicite al usuario que ingrese dos números y luego intente dividir el primer número por el segundo.
o	Use un bloque try-catch para manejar posibles excepciones como DivideByZeroException y FormatException.
o	Cree una excepción personalizada llamada NegativeNumberException que se lance si alguno de los números ingresados es negativo.
o	En el bloque finally, imprima un mensaje que indique que la ejecución del bloque try-catch ha finalizado.
2.	Escriba un programa que realice las siguientes tareas:
•	Implemente una validación en la clase ContactManager para asegurar que los contactos no tengan nombres vacíos.
•	Cree una excepción personalizada DuplicateContactException que se lance cuando se intente agregar un contacto con el mismo ID.
•	Utilice un bloque try-catch-finally para manejar los errores al actualizar contactos.
•	Implemente la gestión de transacciones para asegurar que las operaciones de agregar y actualizar contactos sean atómicas.

 * 
 * 
 */


using ProgramsForLearning.HomeWork11.Exceptions;
using ProgramsForLearning.HomeWork11.Helpers;
using ProgramsForLearning.HomeWork11;
using ProgramsForLearning.HomeWork11.Services;

try
{
    // Solicitar al usuario que ingrese dos números
    Console.WriteLine("Enter the first number:");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second number:");
    int num2 = int.Parse(Console.ReadLine());

    // Verificar si alguno de los números es negativo
    if (num1 < 0 || num2 < 0)
    {
        throw new NegativeNumberException("Numbers must be non-negative.");
    }

    // Intentar realizar la división
    int result = num1 / num2;
    Console.WriteLine("Result: " + result);
}
catch (NegativeNumberException ex)
{
    // Manejar la excepción personalizada
    Console.WriteLine("An error occurred: " + ex.Message);
}
catch (DivideByZeroException ex)
{
    // Manejar la excepción de división por cero
    Console.WriteLine("Cannot divide by zero: " + ex.Message);
}
catch (FormatException ex)
{
    // Manejar la excepción de formato
    Console.WriteLine("Invalid input format: " + ex.Message);
}
finally
{
    // Código que siempre se ejecuta
    Console.WriteLine("Execution of the try-catch block is complete.");
}



var contactManager = new ContactManager();
try
{
    contactManager.AddContact(new Contact { Id = 1, Name = "John", LastName = "Doe", Email = "john@example.com", PhoneNumber = "123-456-7890" });
    contactManager.AddContact(new Contact { Id = 1, Name = "Jane", LastName = "Doe", Email = "jane@example.com", PhoneNumber = "987-654-3210" });
}
catch (DuplicateContactException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}
