
namespace DelegatesLambdaExpressions4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates4");


            ////Variant 1
            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = numbers.Where(IsEven);

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            //Variant 2 Lambda Expressions without IsEven 
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = numbers.Where(number => number % 2 == 0);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }

        }


        ////Variant 1
        //static bool IsEven(int number)
        //{
        //    return number % 2 == 0;
        //}
    }
}
