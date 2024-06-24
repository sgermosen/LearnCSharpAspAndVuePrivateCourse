
using ProgramsForLearning.Program11;
using ProgramsForLearning.Program5.Models;
using ProgramsForLearning.Program11.Models;
using ProgramsForLearning.Program11.Exceptions;

try
{

bool validExcution = true;

var contactManager = new ContactManager();

    //var contact = new ContactModel
    //{
    //    Id = "jkasdhajkshdkjash",
    //    Address = "Calle Luna",
    //    Age = 15,
    //    Email = "email@email.com",
    //    LastName = "Roger",
    //    Name = "Zapata",
    //    Phone = "512454855"
    //};
    //var contactManager = new ContactManager();

    //var contactModel = new ContactModel
    //{
    //    Id = "1",
    //    Address = "Calle Luna",
    //    Age = 15,
    //    Email = "email@email.com",
    //    LastName = "Roger",
    //    Name = "Zapata",
    //    Phone = "512454855"
    //};
    var contactModel = new ContactModel
    {
        Id = "1",
        Address = "Calle Luna",
        Age = 15,
        Email = "email@email.com",
        LastName = string.Empty,
        Name = string.Empty,
        Phone = "512454855"
    };
    contactManager.AddContact(contactModel);

 

var contactModel2 = new ContactModel
{
    Id = "2",
    Address = "Calle es Calle, esquina es esquina",
    Age = 15,
    Email = "email@email.com",
    LastName = "Roger",
    Name = "Zapata",
    Phone = "512454855"
};
contactManager.AddContact(contactModel2);

    Console.ReadKey();
var contact1FromDB = contactManager.GetContactById(1);
var contact2FromDB = contactManager.GetContactById(2);

Console.WriteLine($"La direccion 1 es: {contact1FromDB.Address}");
Console.WriteLine($"La direccion 2 es: {contact2FromDB.Address}");


var contact = new Contact
{
    Id = 3,
    Address = "Calle Parcha",
    Age = 15,
    Email = "email@email.com",
    LastName = "Roger",
    Name = "Zapata",
    Phone = "512454855"
};
//try
//{
    contactManager.UpdateContact(contact);
//}
//catch (ContactNotFoundException ex)
//{
//    Console.WriteLine(ex.Message);
//}    

var contactFromDB = contactManager.GetContactById(1);  

Console.WriteLine($"La direccion es: {contactFromDB.Address}");

Console.ReadKey();


   // int[] numbers = { 1, 2, 3, 4, 5 };

   // Console.WriteLine($"el elemento 6 es: {numbers[5]}");

   

   // var persons = new List<Person>();
   // Person newPerson;


   // newPerson = new Person
   // {
   //     Age = 27,
   //     LastName = "Lebron",
   //     Sex = 'M',
   //     Name = "Alberto"
   // };

   // persons.Add(newPerson);

   // newPerson.Age = 1;
   // newPerson.Name = "Juan";
   // newPerson.LastName = "Pedro";
   // newPerson.Sex = 'M';

   // persons.Add(newPerson);

   // persons.Add(new Person
   // {
   //     Age = 25,
   //     LastName = "Santiago",
   //     Sex = 'M',
   //     Name = "Alberto"
   // });

   //// Console.WriteLine($"el elemento 3 es: {persons[2].Name}");
   // Console.WriteLine($"el elemento 4 es: {persons[3].Name}");

    Console.ReadKey();


    var basicMath = new BasicCalculator();
    basicMath.SetBrand("Toshiba2");
    Console.WriteLine(basicMath.PrintModel());

    BasicCalculator.PrintProgramHeader(string.Empty, string.Empty, string.Empty);


    int typedOption = 0;

    typedOption = Convert.ToInt32(Console.ReadLine());


    //if (validExcution)
    //{
    if (BasicCalculator.ValidateInValidOption(typedOption))
    {
        Console.WriteLine("A ti te dejaron caer cuando chiquito, verdad?");
    }
    else
    {

        Console.WriteLine("Digite el primer Número: ");
        decimal typedNumber1 = Convert.ToDecimal(Console.ReadLine());

        int wantToContinue = 0;
        Console.WriteLine("Desea Agregar un número?");
        Console.WriteLine("1. Si, 2.No");
        wantToContinue = Convert.ToInt32(Console.ReadLine());

        List<decimal> typedNumbers = new List<decimal>();
        while (wantToContinue == 1)
        {
            Console.Write("Digite otro Número: ");

            //try
            //{
            typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}



            Console.WriteLine("Desea Agregar un número?");
            Console.WriteLine("1. Si, 2.No");
            wantToContinue = Convert.ToInt32(Console.ReadLine());

        }

        decimal operationResult = 0;
        switch (typedOption)
        {
            case 1:
                operationResult = BasicCalculator.MakeSum(typedNumber1, typedNumbers);
                break;
            case 2:
                BasicCalculator.MakeSubstraction(typedNumber1, typedNumbers, ref operationResult);
                break;
            case 3:
                operationResult = BasicCalculator.MakeMultiplication(typedNumber1, typedNumbers);
                break;
            case 4:
                operationResult = BasicCalculator.MakeDivision(typedNumber1, typedNumbers);
                break;
            default:
                operationResult = 0;
                break;
        }
        Console.WriteLine($"El Resultado es: {operationResult}");
        Console.WriteLine($"Terminamos...");
    }
    //}
    //else
    //{
    //    Console.WriteLine("Tuvimos un error en algun lado");
    //}
}
 
catch (ArgumentOutOfRangeException )
{
    Console.WriteLine("Ocurrio un error intentando acceder a un elemento que no existe en una lista");

}
catch (ContactIncompleteInformationException  ex)
{
    Console.WriteLine(ex.ContactId );
    Console.WriteLine(ex.Message );

}
catch (ArgumentException) // ex)
{// throw new Exception(ex.Message);
    //Console.WriteLine(ex.Message);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Ocurrio un error intentando acceder a un indice que no existe");

}
catch (DivideByZeroException)
{
    Console.WriteLine("Ocurrio un error de intento de dividir entre cero");
}
catch (ArithmeticException)
{
    Console.WriteLine("Ocurrio un error aritmetico");
    //validExcution = false;
}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Ocurrio un error aritmetico");
//}
catch (ContactNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Ocurrio un error que no pude manejar");
    Console.WriteLine($"Este es el error, pero está en ingles, sorry: {ex.Message}");
    //validExcution = false;
}
finally
{
    Console.WriteLine("Como quiera pasé por aquí");
}

