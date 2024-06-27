namespace ProgramsForLearning.Program14.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsFavorite { get; set; }
        public DateTime BornDate { get; set; }
        public decimal DebAmount { get; set; }
        public int SexId { get; set; }
    }
}
