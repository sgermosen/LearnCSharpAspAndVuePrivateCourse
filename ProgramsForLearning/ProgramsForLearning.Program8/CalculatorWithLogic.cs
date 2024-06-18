
using ProgramsForLearning.Program8.Contracts;

namespace ProgramsForLearning.Program8
{
    public class CalculatorWithLogic : ICalculator, ICalculatorExtra
    {
        public int Brand { get; set; }

        public decimal Add(decimal value1, decimal value2)
        {
            return value1 + value2;
        }
         
        public decimal Multiplication(decimal value1, decimal value2)
        {
            return value1 * value2; 
        }

        public decimal Substract(decimal value1, decimal value2)
        {
            return value1 - value2;
        }

        public decimal Division(decimal value1, decimal value2)
        {
            if (value2 == 0)
            {
                return 0;
            }
            return value1 / value2;
        }
        public decimal Pound(decimal value)
        {
            return value * value;
        }
    }
}
