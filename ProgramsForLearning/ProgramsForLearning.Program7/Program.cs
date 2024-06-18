

using ProgramsForLearning.Program7;

var calc = new CalculatorAdv();

decimal a = 56.6m;
decimal b = 40.1m;

string val1 = "56.6m";
string val2 = "40.1m";

int valint1 = 1;
int valint2 = 2;
var resultStr = calc.Add(val1, val2);
var resultIntThanIsNotReallyInt = calc.Add(valint1, valint2);
Console.WriteLine(resultIntThanIsNotReallyInt);


//decimal resultdef = 0;

//calc.Add(a, b, ref resultdef);
//Console.WriteLine(resultdef);
//resultdef = 0;
//calc.Add(result: ref resultdef, value2: b, value1: a);
//Console.WriteLine(resultdef);
//resultdef = 0; 
//calc.Add(value1: a, value2: b, result: ref resultdef);
//Console.WriteLine(resultdef);

//calc.Add(a, ref resultdef, 0, 1);

//Console.WriteLine(resultdef);
//resultdef = 0;
//calc.Add(value1: a, operation: 1, result: ref resultdef);
//Console.WriteLine(resultdef);


//Console.WriteLine(resultdef);


var sumByStatic = CalculatorAdv.MakeSum(valint1, valint2);