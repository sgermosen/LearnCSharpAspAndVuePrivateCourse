namespace ProgramsForLearning.Program5.Models
{
    public partial class Person
    { 
        public void MessageFromPartialExtended()
        {
            Console.WriteLine("Esto es un mensaje desde una clase parcial");
        }
        public Person CreatePerson(string name, string lastName, int age, char sex = 'M')
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Sex = sex;
            return this;
        }
        public void CreatePersonWithoutReturn(string name, string lastName, int age, char sex = 'M')
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Sex = sex;
        }
        public bool IsAdult()
        {
            if (CalculateAge(DateTime.Now) > 18)
                return true;

            return false;

        }
        private int CalculateAge(DateTime bornDate)
        {
            return 15;
        }
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
    }
}
