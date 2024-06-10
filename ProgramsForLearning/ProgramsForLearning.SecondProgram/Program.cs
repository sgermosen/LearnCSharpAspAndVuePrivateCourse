namespace ProgramsForLearning.SecondProgram
{
    class Program
    {

        static void Main(string[] args)
        {

            /*
             * 
             * Lesson
             * 
            */

            /*
             Console.WriteLine("Bienvenido a nuestra calculadora Básica");
Console.WriteLine("En este proyecto usted va a escoger una opción de la operación que desea realizar");
Console.WriteLine("Y posterior a eso podrá escoger los números a los cuales les desea realizar dicha operación");

Console.Write("Bienvenido a nuestra calculadora Básica \n");
Console.Write("En este proyecto usted va a escoger una opción de la operación que desea realizar \n");
Console.Write("Y posterior a eso podrá escoger los números a los cuales les desea realizar dicha operación \n");
*/
            //Console.Write("Bienvenido a nuestra calculadora Básica\nEn este proyecto usted va a escoger una opción de la operación que desea realizar \nY posterior a eso podrá escoger los números a los cuales les desea realizar dicha operación \n");



            Console.WriteLine(@"Bienvenido a nuestra calculadora Básica
En este proyecto usted va a escoger una opción de la operación que desea realizar
Y posterior a eso podrá escoger los números a los cuales les desea realizar dicha operación.");


            /*Console.Write("Digite un valor para mostrarle ese mismo valor: ");
            var selectedOption = Console.ReadLine();
            Console.WriteLine("Digite un segundo valor para mostrarle el valor numerico de ese valor digitado: ");
            var selectedOptionNumber = Console.Read() @ 64 ñ 164 271;  
            */

            //Console.WriteLine("1. Suma         2. Resta        3. Multiplicación       4. Divición     5. Cerrar");
            /*Console.Write("1. Suma \t\t");
            Console.Write("2. Resta\t\t");
            Console.Write("3. Multiplicación\t\t");
            Console.Write("4. Divición\t\t");
            Console.Write("5. Cerrar\t\t");
            */
            Console.WriteLine("1. Suma \t\t 2. Resta  \t\t 3. Multiplicación  \t\t 4. Divición  \t\t 5. Cerrar");
            Console.Write("Digite un numero del 1 al 5, para indicar la operación que usted desea realizar: ");

            /*var typedOption = Console.ReadLine();
            Console.Write("Digite el primer Número: ");
            //var typedInput1 = Console.ReadLine();
            string typedInput1 = Console.ReadLine();
            //var typedNumber1 = decimal.Parse(typedInput1);
            //var typedNumber1 = Convert.ToDecimal(typedInput1);
            decimal typedNumber1 = Convert.ToDecimal(typedInput1);

            Console.Write("Digite el segundo Número: ");
            //var typedNumber2 = decimal.Parse(Console.ReadLine());
            //var typedNumber2 = Convert.ToDecimal(Console.ReadLine());
            decimal typedNumber2 = Convert.ToDecimal(Console.ReadLine());

            //var operationResult = typedNumber1 + typedNumber2;
            decimal operationResult = typedNumber1 + typedNumber2;

            */

            int typedOption = 0;
            typedOption = Convert.ToInt32(Console.ReadLine());


            // (typedOption > 5 || typedOption < 1)
            // if (typedOption >= 6 || typedOption <= 0)
            if (typedOption > 5 || typedOption <= 0)
            {
                Console.WriteLine("A ti te dejaron caer cuando chiquito, verdad?");
            }
            else
            {

                Console.Write("Digite el primer Número: ");
                decimal typedNumber1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Digite el segundo Número: ");
                decimal typedNumber2 = Convert.ToDecimal(Console.ReadLine());

                //decimal operationResult = new decimal();
                //decimal operationResult = 0;
                decimal operationResult;

                /*
                if (typedOption == 1)
                {
                    var internalOperation = typedNumber2 + typedNumber1;
                    operationResult = internalOperation;
                }
                if (typedOption == 2)
                {
                    var internalOperation = typedNumber1 - typedNumber2;
                    operationResult = internalOperation;
                }
                if (typedOption == 3)
                {
                    var internalOperation = typedNumber2 * typedNumber1;
                    operationResult = internalOperation;
                }
                if (typedOption == 4)
                {
                    var internalOperation = typedNumber1 / typedNumber2;
                    operationResult = internalOperation;
                }
                if (typedOption == 5)
                {
                    Console.WriteLine("Adios....");
                }
                */
                /*
                if (typedOption == 1)
                {
                    var internalOperation = typedNumber2 + typedNumber1;
                    operationResult = internalOperation;
                }
                else
                {
                    if (typedOption == 2)
                    {
                        var internalOperation = typedNumber1 - typedNumber2;
                        operationResult = internalOperation;
                    }
                    else
                    {
                        if (typedOption == 3)
                        {
                            var internalOperation = typedNumber2 * typedNumber1;
                            operationResult = internalOperation;
                        }
                        else
                        {
                            if (typedOption == 4)
                            {
                                var internalOperation = typedNumber1 / typedNumber2;
                                operationResult = internalOperation;
                            }
                            else
                            {
                                //if (typedOption == 5)
                                //{
                                //    operationResult = 0;
                                //    Console.WriteLine("Adios....");
                                //}
                                //else
                                //{
                                    operationResult = 0;
                                    Console.WriteLine("Adios....");
                               // }
                            }
                        }
                    }
                    operationResult = 0;
                    Console.WriteLine("Adios....");
                }
                */
                /*
                if (typedOption == 1)
                {
                    var internalOperation = typedNumber2 + typedNumber1;
                    operationResult = internalOperation;
                }
                else if (typedOption == 2)
                {
                    var internalOperation = typedNumber1 - typedNumber2;
                    operationResult = internalOperation;
                }
                else if (typedOption == 3)
                {
                    var internalOperation = typedNumber2 * typedNumber1;
                    operationResult = internalOperation;
                }
                else if (typedOption == 4)
                {
                    var internalOperation = typedNumber1 / typedNumber2;
                    operationResult = internalOperation;
                }
                //else if (typedOption == 5)
                else
                {
                    operationResult = 0;
                    Console.WriteLine("Adios....");
                }
                */
                switch (typedOption)
                {
                    case 1:
                        operationResult = typedNumber1 + typedNumber2;
                        break;
                    case 2:
                        operationResult = typedNumber1 - typedNumber2;
                        break;
                    case 3:
                        operationResult = typedNumber1 * typedNumber2;
                        break;
                    case 4:
                        operationResult = typedNumber1 / typedNumber2;
                        break;
                    default:
                        operationResult = 0;
                        break;
                }
                Console.WriteLine($"El Resultado es: {operationResult}");
                Console.WriteLine($"Terminamos...");
            }


            Console.ReadKey();

            /*
             * 
             * Putting in Practice
             * 
            */
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
                case var g when (g >= 90 ):
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
        }
    }
}

