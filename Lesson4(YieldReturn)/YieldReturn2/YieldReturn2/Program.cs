namespace YieldReturn2
{
    internal class Program
    {
        public static IEnumerable<int> FilterEvenNumbers(IEnumerable<int> numbers)
        {
            if (numbers == null)
                yield break;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                    yield return number;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Yield Return2");
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            foreach (var number in FilterEvenNumbers(numbers))
            {
                Console.WriteLine(number);
            }
        }
    }
}
