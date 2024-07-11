namespace ProgramsForLearning.HomeWork5
{
    internal class Student
    {
        // Campos privados
        private string name;
        private int age;
        private double grade;

        // Propiedades para acceder a los campos
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        // Método para mostrar la información del estudiante
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Grade: " + Grade);
        }

    }
}
