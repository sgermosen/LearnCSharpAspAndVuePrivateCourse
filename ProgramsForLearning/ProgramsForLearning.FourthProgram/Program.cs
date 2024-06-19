
//while
//do while
//for
//foreach

//int counter = 0;
//int index = 1;
//string[] names = { "Pedro", "Pablo", "Juan" };

//while (index <= 5)
//{
//    //  counter++;

//    //Console.WriteLine(counter.ToString());
//    Console.WriteLine(index);
//    //counter = counter + 1;
//    index++;
//    //counter += 1; 
//}
//index = 0;
////while (index < names.Length ) //  names.Count())
//while (index <= names.Length - 1) //  names.Count())
//{
//    Console.WriteLine(names[index]);
//    index++;
//}


//index = 1;

//do
//{
//    Console.WriteLine(index);
//    index++;
//}
//while (index <= 5);

//index = 0;
//do
//{
//    Console.WriteLine(names[index]);
//    index++;
//}
//while (index <= names.Length - 1);


//index = 1;
//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine(index);
//    index++; 
//}

//for (index = 1; index <= 5; index++)
//{
//    Console.WriteLine(index);
//    // counter++; 
//}

//index = 0;
//for (int i = 0; i <= names.Length - 1; i++)
//{
//    Console.WriteLine(names[index]);
//    index++;
//}


//int[] numbers = { 1, 2, 3, 4, 5 };

//foreach (int item in numbers)
//{
//    Console.WriteLine(item);
//}


//foreach (var name in names)
//{
//    Console.WriteLine(name);

//}


int[,] matrix = {
                { 1, 2, 3 }, // Fila 0
                { 4, 5, 6 }, // Fila 1
                { 7, 8, 9 }  // Fila 2
            };
string[,] matrixRecord = {
                { "Juan", "Pedro", "M" }, // Fila 0
                { "Alberto", "Santiago", "M" }, // Fila 1
                { "Juana", "Contreras", "F" }, // Fila 2
            };

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrixRecord[i, j] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine(@"Bienvenido a nuestra calculadora Básica
En este proyecto usted va a escoger una opción de la operación que desea realizar
Y posterior a eso podrá escoger los números a los cuales les desea realizar dicha operación.");
Console.WriteLine("1. Suma \t\t 2. Resta  \t\t 3. Multiplicación  \t\t 4. Divición  \t\t 5. Cerrar");
Console.Write("Digite un numero del 1 al 5, para indicar la operación que usted desea realizar: ");
int typedOption = 0;
typedOption = Convert.ToInt32(Console.ReadLine());
if (typedOption > 5 || typedOption <= 0)
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

    //int index = 1;

    //decimal[] typedNumbers = new decimal[index];
    List<decimal> typedNumbers = new List<decimal>();
    while (wantToContinue == 1)
    {
        Console.Write("Digite otro Número: ");
        // decimal typedNumber = Convert.ToDecimal(Console.ReadLine());

        //    typedNumbers[index - 1] = typedNumber;
        //    index++;

        //    decimal[] tempTypedNumers = typedNumbers;
        //    typedNumbers = new decimal[index];

        //    //var j = 0;
        //    //foreach (decimal number in tempTypedNumers)
        //    //{
        //    //    typedNumbers [j] = number;
        //    //    j++;
        //    //}
        //    for (int i = 0; i < tempTypedNumers.Length; i++)
        //    {
        //        typedNumbers[i] = tempTypedNumers[i];
        //    }

        // typedNumbers.Add(typedNumber);
        typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

        Console.WriteLine("Desea Agregar un número?");
        Console.WriteLine("1. Si, 2.No");
        wantToContinue = Convert.ToInt32(Console.ReadLine());

    }


    decimal operationResult = 0;
    switch (typedOption)
    {
        case 1:
            operationResult = MakeSum(typedNumber1, typedNumbers);
            break;
        case 2:
            MakeSubstraction(typedNumber1, typedNumbers, ref operationResult);
            break;
        case 3:
            operationResult = MakeMultiplication(typedNumber1, typedNumbers);
            break;
        case 4:
            operationResult = MakeDivision(typedNumber1, typedNumbers);
            break;
        default:
            operationResult = 0;
            break;
    }
    Console.WriteLine($"El Resultado es: {operationResult}");
    Console.WriteLine($"Terminamos...");
}


static decimal MakeMultiplication(decimal typedNumber1, List<decimal> typedNumbers)
{
    decimal result = typedNumber1;
    //result += typedNumber1;
    foreach (decimal number in typedNumbers)
    {
        result *= number;
    }
    return result;
}

static decimal MakeDivision(decimal typedNumber1, List<decimal> typedNumbers)
{
    decimal result = typedNumber1;
    //result += typedNumber1;
    foreach (decimal number in typedNumbers)
    {
        result /= number;
    }
    return result;
}

static decimal MakeSum(decimal typedNumber1, List<decimal> typedNumbers)
{
    decimal result = typedNumber1;
    //result += typedNumber1;
    foreach (decimal number in typedNumbers)
    {
        result += number;
    }
    return result;
}

static void MakeSubstraction(decimal typedNumber1, List<decimal> typedNumbers, ref decimal result)
{
    result = typedNumber1;
    foreach (decimal number in typedNumbers)
    {
        result -= number;
    }
}

