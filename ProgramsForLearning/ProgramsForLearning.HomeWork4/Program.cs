/* 
 Escriba un programa que realice las siguientes tareas:
o	Declare e inicialice un arreglo de enteros con 10 números.
o	Use un bucle while para imprimir todos los números del arreglo.
o	Use un bucle do while para imprimir todos los números del arreglo en orden inverso.
o	Use un bucle for para calcular y imprimir el promedio de los números en el arreglo.
o	Utilice un bucle foreach para calcular la suma de todos los elementos del array y mostrar el resultado en la consola.

 
 
 */


// Declarar e inicializar un arreglo de enteros con 10 números
int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

// Usar un bucle while para imprimir todos los números del arreglo
int index = 0;
while (index < numbers.Length)
{
    Console.WriteLine(numbers[index]);
    index++;
}

// Usar un bucle do while para imprimir todos los números del arreglo en orden inverso
index = numbers.Length - 1;
do
{
    Console.WriteLine(numbers[index]);
    index--;
} while (index >= 0);

// Usar un bucle for para calcular y imprimir el promedio de los números en el arreglo
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
double average = (double)sum / numbers.Length;
Console.WriteLine("Average: " + average);

// Declarar e inicializar una matriz de enteros (3x3)
int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

// Usar bucles anidados para imprimir los valores de la matriz
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
