using ProgramsForLearning.Program8.Contracts;

namespace ProgramsForLearning.Program8
{
    public class CalculatorEvolved
    {
        // private readonly Calculator _calculator;
        private readonly ICalculator _calculator;
        // private readonly ICalculator calculator;

        //public CalculatorEvolved()
        //{
        //    _calculator = new Calculator();
        //}
        public CalculatorEvolved(ICalculator calculator)
        {
            _calculator = calculator;
            // this.calculator = calculator;
        }

        public void MakeOperations()
        {
            decimal a = 56.6m;
            decimal b = 40.1m;

            var sum = _calculator.Add(a, b);
            var subs = _calculator.Substract(a, b);
            var mult = _calculator.Multiplication(a, b);
            var div = _calculator.Division(a, b);


            Console.WriteLine(sum);
            Console.WriteLine(subs);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }

        public void MakeOperations(decimal a, decimal b)
        {
            var sum = _calculator.Add(a, b);
            var subs = _calculator.Substract(a, b);
            var mult = _calculator.Multiplication(a, b);
            var div = _calculator.Division(a, b);

            Console.WriteLine(sum);
            Console.WriteLine(subs);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }

    }
}
