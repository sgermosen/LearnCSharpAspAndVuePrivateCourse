namespace ProgramsForLearning.FisrtProgram
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             Tipos de Datos Primitivos en C#
1.	Enteros:
o	byte: Representa un número entero de 8 bits sin signo. Rango: 0 a 255.
o	sbyte: Representa un número entero de 8 bits con signo. Rango: -128 a 127.
o	short: Representa un número entero de 16 bits con signo. Rango: -32,768 a 32,767.
o	ushort: Representa un número entero de 16 bits sin signo. Rango: 0 a 65,535.
o	int: Representa un número entero de 32 bits con signo. Rango: -2,147,483,648 a 2,147,483,647.
o	uint: Representa un número entero de 32 bits sin signo. Rango: 0 a 4,294,967,295.
o	long: Representa un número entero de 64 bits con signo. Rango: -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807.
o	ulong: Representa un número entero de 64 bits sin signo. Rango: 0 a 18,446,744,073,709,551,615.
2.	Punto Flotante:
o	float: Representa un número de punto flotante de precisión simple de 32 bits. Aproximadamente 7 dígitos de precisión.
o	double: Representa un número de punto flotante de doble precisión de 64 bits. Aproximadamente 15-16 dígitos de precisión.
o	decimal: Representa un número decimal de 128 bits. Aproximadamente 28-29 dígitos de precisión. Utilizado principalmente en aplicaciones financieras y monetarias.
3.	Carácter:
o	char: Representa un carácter Unicode de 16 bits. Rango: '\u0000' a '\uffff'.
4.	Booleano:
o	bool: Representa un valor booleano. Puede ser true o false.
5.	Cadena de Caracteres:
o	string: Representa una secuencia de caracteres Unicode. Aunque string no es un tipo de dato primitivo en sí, es considerado básico y fundamental en C#.

             */
            //Las variables son espacios de memoria en los que almacenamos datos que pueden cambiar a lo largo de la ejecución del programa. Cada variable tiene un tipo de dato asociado que define qué tipo de información puede almacenar y cómo se maneja esa información.
            int edad = 25;
            float altura = 1.75f;
            double peso = 70.5;
            char inicial = 'A';
            string nombre = "Juan";
            bool esEstudiante = true;

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Inicial: " + inicial);
            Console.WriteLine("Es estudiante: " + esEstudiante);

            int a = 10;
            double b = a; // Conversión implícita
            Console.WriteLine(b);

            double c = 9.8;
            int d = (int)c; // Conversión explícita
            Console.WriteLine(d);

            string numeroTexto = "123";
            int numero = Convert.ToInt32(numeroTexto);
            Console.WriteLine(numero);

            double decimalTexto = Convert.ToDouble("12.34");
            Console.WriteLine(decimalTexto);


        }
    }
}
