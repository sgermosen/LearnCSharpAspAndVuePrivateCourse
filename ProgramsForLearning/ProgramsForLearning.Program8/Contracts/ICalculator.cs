namespace ProgramsForLearning.Program8.Contracts
{
    public interface ICalculator
    {
        public int Brand { get; set; }
        public decimal Add(decimal value1, decimal value2);
        public decimal Substract(decimal value1, decimal value2);
        public decimal Multiplication(decimal value1, decimal value2);
        public decimal Division(decimal value1, decimal value2);

    }
}
