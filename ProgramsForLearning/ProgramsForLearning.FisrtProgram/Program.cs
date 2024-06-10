using System;

namespace ProgramsForLearning.FisrtProgram
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
             * 
             * Putting in Practice
             * 
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
            decimal heightInKm = Convert.ToDecimal(height/100);
            string weightText = weight.ToString(); 
            double weightInPounds = (float.Parse(weightText) * 2.5);

            // print convertions
            Console.WriteLine($"Age as text: {ageText}");
            Console.WriteLine($"Height in centimeters: {heightInCm}" );
            Console.WriteLine($"Height in kilometes: {heightInKm}" );
            Console.WriteLine($"Weight as text: {weightText}" );
            Console.WriteLine($"Weight in pounds: {weightInPounds}" );



        }
    }
}
