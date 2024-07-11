/* 
Escriba un programa que realice las siguientes tareas:
o	Declare e inicialice un arreglo de enteros con las edades de 5 personas.
o	Declare e inicialice un arreglo de cadenas con los nombres de 5 personas.
o	Itere sobre los arreglos e imprima cada nombre junto con su edad.
o	Defina una función que tome un nombre y una edad como parámetros, y devuelva un saludo personalizado.
o	Llame a esta función para cada par de nombre y edad en los arreglos e imprima el resultado.
 */

// Declare and initializar an array of ints for ages of people  
int[] ages = { 25, 30, 35, 40, 45 };

// Declare and initialize an array of strings with the names  
string[] names = { "Alicia", "Bob", "Juan", "David", "Carlos" };

// iterate  Iterar sobre los arreglos e imprimir cada nombre junto con su edad
for (int i = 0; i < ages.Length; i++)
{
    Console.WriteLine(names[i] + " is " + ages[i] + " years old.");
}

// Llamar a la función Greet para cada par de nombre y edad en los arreglos e imprimir el resultado
for (int i = 0; i < ages.Length; i++)
{
    string greeting = Greet(names[i], ages[i]);
    Console.WriteLine(greeting);
}


// Definición de la función Greet que toma un nombre y una edad como parámetros, y devuelve un saludo personalizado
static string Greet(string name, int age)
{
    return "Hello, " + name + "! You are " + age + " years old.";
}
