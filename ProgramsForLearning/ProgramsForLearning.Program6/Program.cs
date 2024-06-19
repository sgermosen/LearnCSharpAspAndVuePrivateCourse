
//namespace ProgramsForLearning.Program6; 


//public class Program
//{
//    public static void Main(string[] args)
//    {
using ProgramsForLearning.Program6.Models;

//Console.WriteLine("Hello, World!");

//var derivedClass = new DerivedClass();
//var baseClass = new BaseClass();

//baseClass.DisplayMessage();

//derivedClass.DisplayMessage();

//derivedClass.Name = "Juan";

var basicMath = new AdvanceCalculator();

//basicMath.Brand = "Casio";
//Console.WriteLine(basicMath.PrintModel());

//var newPerson = new Person();


//newPerson.CreatePersonWithoutReturn("Alberto", "Lebron", 27);

//Console.WriteLine(newPerson.GetFullName());

//var newPerson2 = newPerson.CreatePerson("Alberto", "Santiago", 27,'M');

//Console.WriteLine(newPerson2.GetFullName());



var advanceMath = new AdvanceCalculator();


//basicMath.PrintProgramHeader(string.Empty, "", string.Empty);
AdvanceCalculator.PrintProgramHeader(string.Empty, string.Empty, string.Empty);


int typedOption = 0;
typedOption = Convert.ToInt32(Console.ReadLine());
if (AdvanceCalculator.ValidateInValidOption(typedOption))
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
            operationResult = AdvanceCalculator.MakeSum(typedNumber1, typedNumbers);
            break;
        case 2:
            AdvanceCalculator.MakeSubstraction(typedNumber1, typedNumbers, ref operationResult);
            break;
        case 3:
            operationResult = AdvanceCalculator.MakeMultiplication(typedNumber1, typedNumbers);
            break;
        case 4:
            operationResult = AdvanceCalculator.MakeDivision(typedNumber1, typedNumbers);
            break;
        default:
            operationResult = 0;
            break;
    }
    Console.WriteLine($"El Resultado es: {operationResult}");
    Console.WriteLine($"Terminamos...");
}


//    }
//}
