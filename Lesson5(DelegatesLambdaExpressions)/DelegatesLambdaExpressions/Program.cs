namespace DelegatesLambdaExpressions
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
            Console.WriteLine("Delegates");

            Func<int, int, int> mathOperation = Sum;

            var result = mathOperation(5, 10);

            Console.WriteLine(result);
        }
    }
}
