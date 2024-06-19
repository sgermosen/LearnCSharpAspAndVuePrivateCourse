namespace ProgramsForLearning.SecondProgram
{
    class Program
    {

        static void Main(string[] args)
        { 

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

        }
    }
}

