
namespace Day01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MathCasex.FiboVar(15);
            
            bool result = MathCasex.IsPrimeNumber(8);
            Console.WriteLine(result);

            var isPrime = MathCasex.IsPrimeNumber(5);
            Console.WriteLine(isPrime);

            Console.WriteLine(MathCasex.IsPrimeNumber(5));

            //MathCasex.ATM();
            //MathCasex.FizzBuzz(15);
            //MathCasex.SetLocalVariable();
            //MathCasex.ShowMultiplePrint();

        }
    }
}
