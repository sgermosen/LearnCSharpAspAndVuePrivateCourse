namespace ProgramsForLearning.HomeWork7
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public void DisplayContactInfo()
        {
            Console.WriteLine($"Contact: {FullName}, Email: {Email}, Phone: {PhoneNumber}");
        }
    }

}
