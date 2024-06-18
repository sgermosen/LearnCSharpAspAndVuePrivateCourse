
using ProgramsForLearning.Program8.Contracts;

namespace ProgramsForLearning.Program8
{
    public class Calculator : ICalculator, ICalculatorExtra
    {
        public int Brand { get ; set ; }

        public decimal Add(decimal value1, decimal value2)
        {
            return value1 + value2;
        }

        public decimal Division(decimal value1, decimal value2)
        {
            return value1 / value2;
        }

        public decimal Multiplication(decimal value1, decimal value2)
        {
            return value1 * value2; 
        }

        public decimal Pound(decimal value)
        {
            return value * value;
        }

        public decimal Substract(decimal value1, decimal value2)
        {
            return value1 - value2;
        }
    }
}
