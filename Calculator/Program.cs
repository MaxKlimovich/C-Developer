namespace DeveloperC.Calculator;

public class Program
{
    static void Calc(string[] args)
    {
        Calculate calculator = new Calculate();

        if (calculator.ValidateArgs(args))
        {
            var result = calculator.Calculator(args);
            Console.WriteLine($"{result.expression} = {result.result}");
        }
        else
        {
            Console.WriteLine("Entered bad arguments. Program is closed");
        }
    }
}