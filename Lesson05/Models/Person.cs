namespace ProgramsForLearning.Program5.Models
{
    public class Person
    { 
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }

        public string FullName => GetFullName();

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
