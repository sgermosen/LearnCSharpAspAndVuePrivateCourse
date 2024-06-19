
namespace ProgramsForLearning.ThirdProgram
{
    class Program
    {
        string globalString = "Soy una cadena global";
        static void Main(string[] args)
        {
            string globalString = "soy una cadena de alcance general";

            Console.WriteLine(globalString);
            //int number1 = 1;
            ////number1 = new int();
            ////number1 = 1;
            //int number2 = 3;
            //int number3 = 7;
            //int number4 = 9;
            //int number5 = 96;

            int[] numbers1 = new int[5];



            numbers1[0] = 1;
            numbers1[1] = 2;
            numbers1[2] = 3;
            numbers1[3] = 4;
            numbers1[4] = 5;
            Console.WriteLine(numbers1[4]);
            //numbers[5] = 6; //error por estas fuera de las dimenciones lo que vamos a intentar asignar

            string[] names = { "Juan", "Pedro", "Pablo", "De La Mar", "Antonio" };

            Console.WriteLine(names[4]);
            //Console.WriteLine(names[5]); //Error intentando acceder a un elemento por un indice que no existe;

            //int number1 = 3;
            //int number2 = 7;
            //Console.WriteLine(number1);
            //Console.WriteLine(number2);
            //int number3 = number2;
            //Console.WriteLine(number3);
            //number2 = 1111;
            //Console.WriteLine(number2);
            //Console.WriteLine(number3);
            //number3 = 2222;
            //Console.WriteLine(number3);
            //number1 = number3;
            //Console.WriteLine(number1);


            int[] numbers2 = new int[4];
            numbers2[0] = 0;
            numbers2[1] = 1;
            numbers2[2] = 2;
            numbers2[3] = 3;
            //numbers2[4] = 4;

            //numbers2 = numbers1;
            //numbers1 = numbers2;

            //Console.WriteLine(numbers1[4]);

            int valorInicial = 1;
            Console.WriteLine(valorInicial);
            valorInicial = valorInicial + 1;
            Console.WriteLine(valorInicial);
            valorInicial += 1;
            Console.WriteLine(valorInicial);
            valorInicial++;
            Console.WriteLine(valorInicial);

            //for (short i = 0; i < numbers1.Length; i++)
            //for (short i = 5; i > 0; i--)
            for (short i = 0; i < 5; i++)
            {
                //Console.WriteLine($"El Valor de i es: {i}");
                ////Console.WriteLine("El Valor de i es: " + i);
                ////Console.WriteLine(string.Format("El Valor de i es: {0}", i));
                //Console.WriteLine($"El Valor del arreglo en el indice {i} es: {numbers1[i]}");
                //Le Mando unos argumentos
                PrintNumberFromArray(numbers1, i);
            }

            for (int i = 0; i <= 3; i++) //iteration
            {
                PrintNumberFromArray(numbers2, i);
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

                Console.Write("Digite el primer Número: ");
                decimal typedNumber1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Digite el segundo Número: ");
                decimal typedNumber2 = Convert.ToDecimal(Console.ReadLine());

                decimal operationResult = 0;
                switch (typedOption)
                {
                    case 1:
                        operationResult = MakeSum(typedNumber1, typedNumber2);
                        break;
                    case 2:
                        MakeSubstraction(typedNumber1, typedNumber2, ref operationResult);
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

        private static void MakeSubstraction(decimal typedNumber1, decimal typedNumber2, ref decimal result)
        {
            string localString = "soy una cadena de alcance local";
            result = typedNumber1 - typedNumber2;
            Console.WriteLine(localString);
        }

        private static decimal MakeSum(decimal typedNumber1, decimal typedNumber2)
        {
            string localString = "soy una cadena de alcance local";
            return typedNumber1 + typedNumber2;
            Console.WriteLine(localString);
        }

        //                                     parametros
        public static void PrintNumberFromArray(int[] numbers, long i)
        {
            Console.WriteLine($"El Valor de i es: {i}");
            Console.WriteLine($"El Valor del arreglo en el indice {i} es: {numbers[i]}");
        }
    }

}


