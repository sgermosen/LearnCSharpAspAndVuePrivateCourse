/* 
 Dado los siguientes enunciados:
1.	La edad de una persona es 28 años.
2.	La estatura de una persona es 1.75 metros.
3.	El nombre completo de una persona es "Juan Perez".
4.	La inicial del apellido de una persona es 'J'.
5.	El sexo de un estudiante es masculino.
6.	El peso de una persona es 68.5 kilogramos.
7.	La persona es estudiante.
Realice las siguientes tareas:
1.	Declare las variables con los tipos de datos y nombres adecuados.
2.	Asigne los valores proporcionados a las variables.
3.	Imprima los valores de las variables en la consola.
4.	Realice las siguientes conversiones:
o	Convierta la edad de entero a cadena de texto.
o	Convierta la estatura de metros a centímetros (recuerde que 1 metro = 100 centímetros).
o	Convierta el peso de kilogramos a libras (investigue la formula necesaria para hacer este proceso).
o	Imprima los resultados de las conversiones en la consola.

 */

// declare values and asign values
int age = 28;
float height = 1.75f;
string fullName = "John Perez";
char lastNameInitial = 'J';
double weight = 68.5;
bool isStudent = true;

// print variables values
Console.WriteLine("Full Name: " + fullName);
Console.WriteLine($"Age: {age}");
Console.Write("Height: " + height + " meters\n");
Console.Write(string.Format("Last Name Initial: {0}", lastNameInitial));
Console.Write("\nWeight: " + weight + " kg\n");
Console.WriteLine($"Is Student: {isStudent}");

// convert datatypes 
string ageText = age.ToString();
int heightInCm = (int)(height * 100);
decimal heightInKm = Convert.ToDecimal(height / 100);
string weightText = weight.ToString();
double weightInPounds = (float.Parse(weightText) * 2.5);

// print convertions
Console.WriteLine($"Age as text: {ageText}");
Console.WriteLine($"Height in centimeters: {heightInCm}");
Console.WriteLine($"Height in kilometes: {heightInKm}");
Console.WriteLine($"Weight as text: {weightText}");
Console.WriteLine($"Weight in pounds: {weightInPounds}");
