namespace ProgramsForLearning.HomeWork6
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public void DisplayInformation()
        {
            Console.WriteLine($"Name: {FullName}, Age: {Age}, Sex: {Sex}");
        }
    }

}
