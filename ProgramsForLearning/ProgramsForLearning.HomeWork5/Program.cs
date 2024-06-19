/*
  
 Escriba un programa que realice las siguientes tareas:
o	Defina una clase llamada Student con los siguientes campos: name, age, grade.
o	Cree propiedades para acceder a cada uno de los campos.
o	Defina un método llamado DisplayInfo que imprima la información del estudiante.
o	En el método Main, cree dos objetos de la clase Student, asigne valores a sus propiedades y llame al método DisplayInfo para cada objeto.

 
 */

// Crear un objeto de la clase Student
using ProgramsForLearning.HomeWork5;

Student student1 = new Student();
student1.Name = "John";
student1.Age = 20;
student1.Grade = 90.5;
student1.DisplayInfo();

// Crear otro objeto de la clase Student
Student student2 = new Student();
student2.Name = "Jane";
student2.Age = 22;
student2.Grade = 95.0;
student2.DisplayInfo();
