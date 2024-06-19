namespace ProgramsForLearning.Program5.Models
{
    public partial class Person
    {
        public string GetFullName()
        {
            return $"{Name} {LastName}";
        }
        public void MessageFromPartial()
        {
            Console.WriteLine("Esto es un mensaje desde una clase parcial");
        }
    }
}
