namespace ProgramsForLearning.Program8
{
    public class CalculatorAdv : Calculator
    {
        public string Brand { get; set; }

        public static decimal MakeSum(decimal value1, decimal value2)
        {
            return value1 + value2;
        }

        public decimal Add(decimal value1, decimal value2)
        {
            Brand = "casio";
            return value1 + value2 + 1;
        }
    }
}
