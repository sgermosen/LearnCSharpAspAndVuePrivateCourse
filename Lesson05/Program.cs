//string[,] matrixRecord = { 
//    { "Juan", "Pedro", "M" }, // Fila 0
//    { "Alberto", "Santiago", "M" }, // Fila 1
//    { "Juana", "Contreras", "F" }, // Fila 2
//};

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(matrixRecord[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//decimal i = 0;
//decimal i ;
//  i = new decimal();
// i = 0;


//using ProgramsForLearning.FivethProgram.Models;

//Person student;
//student = new ProgramsForLearning.FivethProgram.Models.Person();
//student.Age = 1;
////Person employee = new ProgramsForLearning.FivethProgram.Person(); //this crash due compatibility problems
//Person employee = new Person();
//var manager = new Person();

//manager.Age = 1;
//manager.Name = "Juan";
//manager.LastName = "Pedro";
//manager.Sex = 'M';

//var cashier = new Person
//{
//    Age = 2,
//    LastName = "Lebron",
//    Sex = 'M',
//    Name = "Alberto"
//};

//cashier = manager;
//manager = new Person();
//var persons = new List<Person>(); 
//Person newPerson;


// newPerson = new Person
//{
//    Age = 27,
//    LastName = "Lebron",
//    Sex = 'M',
//    Name = "Alberto"
//};

//persons.Add(newPerson);

//newPerson.Age = 1;
//newPerson.Name = "Juan";
//newPerson.LastName = "Pedro";
//newPerson.Sex = 'M';

//persons.Add(newPerson);

//persons.Add(new Person
//{
//    Age = 25,
//    LastName = "Santiago",
//    Sex = 'M',
//    Name = "Alberto"
//});

//foreach (var person in persons)
//{
//    person.SayYourInformation();
//    Console.WriteLine($"Mi Nombre es: {person.GetFullName()}");
//}

//using ProgramsForLearning.FivethProgram.Models;
using ProgramsForLearning.Program5.Models;

var basicMath = new BasicCalculator();
//basicMath.Brand = "Toshiba";
basicMath.SetBrand("Toshiba2");
Console.WriteLine(basicMath.PrintModel());

//basicMath.PrintProgramHeader(string.Empty, "", string.Empty);
BasicCalculator.PrintProgramHeader(string.Empty, string.Empty, string.Empty);


int typedOption = 0;
typedOption = Convert.ToInt32(Console.ReadLine());
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

        typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

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


