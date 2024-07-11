namespace ProgramsForLearning.Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[,] matrixRecord = {
            //    { "Juan", "Pedro", "M" }, // Fila 0
            //    { "Alberto", "Santiago", "M" }, // Fila 1
            //    { "Juana", "Contreras", "F" }, // Fila 2
            //};

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matrixRecord[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //decimal i = 0;
            //decimal i ;
            //  i = new decimal();
            // i = 0;
            Person student;
            student = new Person();
            student.Age = 1;
            Person employee = new Person();
            var manager = new Person();

            manager.Age = 1;
            manager.Name = "Juan";
            manager.LastName = "Pedro";
            manager.Sex = 'M';

            var cashier = new Person
            {
                Age = 2,
                LastName = "Lebron",
                Sex = 'M',
                Name = "Alberto"
            };
            //var person = new Person();
            //person.SayMyFullName();

        }
    }

    public class Person
    {


        // private string _name; // public variables 
        //private string _lastName;
        //private int _age;
        //private char _sex;
        //private string _fullName => $"{name} {lastName}";

        public string Name { get; set; } //auto implemented properties

        //public string Name2
        //{
        //    get
        //    {
        //        return Name;
        //    }
        //    set
        //    {
        //        Name = value;
        //        if (string.IsNullOrEmpty(LastName))
        //        {
        //            LastName = value;
        //        }
        //    } 
        //}

        public string LastName { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
        //public string FullName
        //{
        //    get
        //    {
        //        return $"{Name} {LastName}";
        //    }
        //}
        //public string FullName4
        //{
        //    get
        //    {
        //        return GetFullName();
        //    }
        //}
        //public string FullName2 => $"{Name} {LastName}";
        public string FullName => GetFullName();

        //public string LastName2
        //{
        //    get
        //    {
        //        return lastName;
        //    }
        //    set
        //    {
        //        lastName = value;
        //    }
        //}
        //string fullname
        //{
        //    get
        //    {
        //        return $"{name} {lastName}";
        //    }
        //}

        public void SayYourName()
        {
            Console.WriteLine($"Mi nombre es: {Name}");
        }
        public void SayYourInformation()
        {
            Console.WriteLine($"Mi Nombre es: {Name}, Mi Apellido es: {LastName} y mi edad es: {Age} y me identifico con el sexo: {Sex}");
        }
        public void SayMyFullName()
        {
            Console.WriteLine(FullName);
        }

        public string GetFullName()
        {
            return $"{Name} {LastName}";
        }
    }
}