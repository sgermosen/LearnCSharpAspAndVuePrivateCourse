
/*

Solicite al usuario que ingrese su edad y altura en centímetros.
Determine si el usuario es elegible para unirse a un equipo de baseball, tomando en cuenta que la edad mínima requerida son 18 años y la altura mínima son 1.5 metros (edad >= 18 y altura >= 1.50 metros).
Solicite al usuario que ingrese un número del 1 al 7 y muestre el día de la semana correspondiente según el calendario laboral.
Solicite al usuario que ingrese su calificación numérica y asigne una letra de calificación (A, B, C, D, F) utilizando la sentencia mas adecuada.


 */
// ask user to enter values
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your height in meters:");
float height = float.Parse(Console.ReadLine());

// using if else to determinate if user is elegible to be in a team 
//if (age >= 18)
//{
//    if (height >= 1.50f)
//    {
//        Console.WriteLine("You are not eligible to join the baseball team.");
//    }
//    else
//    {
//        Console.WriteLine("You are not eligible to join the baseball team.");
//    }
//}
//else
//{
//    Console.WriteLine("You are not eligible to join the baseball team.");
//}

if (age >= 18 && height >= 1.50f)
{
    Console.WriteLine("You are eligible to join the baseball team.");
}
else
{
    Console.WriteLine("You are not eligible to join the baseball team.");
}


Console.WriteLine("Enter a number from 1 to 7 to determinate the labor day:");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

// determinate what print with switch
switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Today is Monday.");
        break;
    case 2:
        Console.WriteLine("Today is Tuesday.");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday.");
        break;
    case 4:
        Console.WriteLine("Today is Thursday.");
        break;
    case 5:
        Console.WriteLine("Today is Friday.");
        break;
    case 6:
        Console.WriteLine("Today is Saturday.");
        break;
    case 7:
        Console.WriteLine("Today is Sunday.");
        break;
    default:
        Console.WriteLine("Invalid day of the week.");
        break;
}

Console.WriteLine("Enter your numeric grade:");
int grade = Convert.ToInt32(Console.ReadLine());

//if (grade >= 90)
//{
//    Console.WriteLine("Your grade is A.");
//}
//else if (grade >= 80)
//{
//        Console.WriteLine("Your grade is B.");   
//}

// combining complex decition in a case
switch (grade)
{
    case var g when (g >= 90):
        Console.WriteLine("Your grade is A.");
        break;
    case int n when (n >= 80):
        Console.WriteLine("Your grade is B.");
        break;
    case int n when (n >= 70):
        Console.WriteLine("Your grade is C.");
        break;
    case int n when (n >= 60):
        Console.WriteLine("Your grade is D.");
        break;
    default:
        Console.WriteLine("Your grade is F.");
        break;
}
