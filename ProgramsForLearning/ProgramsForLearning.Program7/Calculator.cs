
namespace ProgramsForLearning.Program7
{
    public abstract class Calculator
    {
        //public decimal Add(decimal value1, decimal value2)
        //{
        //    //var result = value1 + value2;
        //    //return result;
        //    return value1 + value2;

        //}
        //  public decimal Add(decimal value1, decimal value2) => value1 + value2;
        // public decimal Add(decimal value1, decimal value2, ref decimal result ) => result =  value1 + value2;
        public void Add(decimal value1, ref decimal result, decimal value2 = 0, int operation = 0)
        {
            if (operation == 1)
                result = value1 + value2;
            else
                result = value1 - value2;

            // return result; 
        }

        public decimal Add(ref decimal value1, ref decimal value2) => value1 + value2;
      //  public decimal Add(int value1, int value2) => value1 + value2;

        public decimal Add(decimal value1, decimal value2, decimal value3) => value1 + value2 + value3;

        public string Add(string val1, string val2)
        {
            return val1 + val2;
        }

        //public virtual decimal Add(decimal value1, decimal value2)
        //{
        //    return value1 + value2;
        //}
        public abstract decimal Add(decimal value1, decimal value2);
        //{
        //    return value1 + value2;
        //}
    }
}
