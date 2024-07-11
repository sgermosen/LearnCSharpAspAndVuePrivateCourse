namespace ProgramsForLearning.Program5.Models
{ 
    public class BasicCalculator
    {
        private string Brand { get; set; }

        public void SetBrand(string brandName)
        {
            Brand = brandName;
        }

        public string PrintModel()
        {
            return Brand;
        }
        //public void PrintProgramHeader(string header1, string header2, string header3)
        public static void PrintProgramHeader(string header1, string header2, string header3)
        {
            //header1 == "" //this is true
            //            if (header1 != string.Empty) 
            //            {
            //                Console.WriteLine(header1);
            //            }
            //            else
            //            {
            //                Console.WriteLine(@"Bienvenido a nuestra calculadora Básica
            //En este proyecto usted va a escoger una opción de la operación que desea realizar
            //Y posterior a eso podrá escoger los números a los cuales les desea realizar dicha operación.");
            //            }

            //            if (string.IsNullOrEmpty(header1))
            //            {
            //                Console.WriteLine(@"Bienvenido a nuestra calculadora Básica
            //En este proyecto usted va a escoger una opción de la operación que desea realizar
            //Y posterior a eso podrá escoger los números a los cuales les desea realizar dicha operación.");
            //            }
            //            else
            //            {
            //                Console.WriteLine(header1); 
            //            }

            if ((string.IsNullOrEmpty(header1)))
            {
                header1 = @"Bienvenido a nuestra calculadora Básica
En este proyecto usted va a escoger una opción de la operación que desea realizar
Y posterior a eso podrá escoger los números a los cuales les desea realizar dicha operación.";
            }

            // Console.WriteLine(header1);


            if ((string.IsNullOrEmpty(header2)))
            {
                header2 = "1. Suma \t\t 2. Resta  \t\t 3. Multiplicación  \t\t 4. Divición  \t\t 5. Cerrar";
            }

            if ((string.IsNullOrEmpty(header3)))
            {
                header3 = "Digite un numero del 1 al 5, para indicar la operación que usted desea realizar: ";
            }
            Console.WriteLine(header1);

            Console.WriteLine(header2);
            Console.Write(header3);

        }

        public static bool ValidateInValidOption(int typedOption)
        {
            if (typedOption > 5 || typedOption <= 0)
            {
                return true;
            }
            return false;
        }



        public static decimal MakeMultiplication(decimal typedNumber1, List<decimal> typedNumbers)
        {
            decimal result = typedNumber1;

            foreach (decimal number in typedNumbers)
            {
                result *= number;
            }
            return result;
        }

        public static decimal MakeDivision(decimal typedNumber1, List<decimal> typedNumbers)
        {
            decimal result = typedNumber1;
            foreach (decimal number in typedNumbers)
            {
                result /= number;
            }
            return result;
        }

        public static decimal MakeSum(decimal typedNumber1, List<decimal> typedNumbers)
        {
            decimal result = typedNumber1;
            foreach (decimal number in typedNumbers)
            {
                result += number;
            }
            return result;
        }

        public static void MakeSubstraction(decimal typedNumber1, List<decimal> typedNumbers, ref decimal result)
        {
            result = typedNumber1;
            foreach (decimal number in typedNumbers)
            {
                result -= number;
            }
        }

    }
}
