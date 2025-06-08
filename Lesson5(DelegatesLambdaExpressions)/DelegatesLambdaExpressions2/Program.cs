namespace DelegatesLambdaExpressions2
{
    internal class Program
    {
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates2");

            PerformMathOperation(Multiply, 5,10);
        }

        static void PerformMathOperation(Func<int, int, int> mathOperation, int a, int b)
        {
            Console.WriteLine("Very Important Code");

            var orerationResult= mathOperation(a,b);

            Console.WriteLine(orerationResult);

            Console.WriteLine("Super Important Code");


        }
    }
}
