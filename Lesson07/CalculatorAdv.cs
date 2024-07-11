namespace ProgramsForLearning.Program7
{
    public class CalculatorAdv : Calculator //, CalculatorEvolved
    {
        public string Brand { get; set; }
        //public override decimal Add(decimal value1, decimal value2)
        //{
        //    Brand = "casio";
        //    return value1 + value2 + 1;
        //}

        //public   decimal Add(decimal value1, decimal value2)
        //{
        //    Brand = "casio";
        //    return value1 + value2 + 1;
        //}

        public static decimal MakeSum(decimal value1, decimal value2)
        {
            return value1 + value2;
        }

        public override decimal Add(decimal value1, decimal value2)
        {
            Brand = "casio";
            return value1 + value2 + 1;
        }
    }
}
