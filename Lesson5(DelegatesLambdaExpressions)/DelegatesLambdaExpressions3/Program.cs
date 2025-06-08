namespace DelegatesLambdaExpressions3
{
    internal class Program
    {
        delegate int MathOperation(int a, int b);
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
            Console.WriteLine("Delegates3");

            MathOperation mathOperation = Sum;
            PerformMathOperation(Multiply, 5, 10);
        }

        static void PerformMathOperation(MathOperation mathOperation, int a, int b)
        {
            Console.WriteLine("Very Important Code");

            var orerationResult = mathOperation(a, b);

            Console.WriteLine(orerationResult);

            Console.WriteLine("Super Important Code");


        }
    }
}
