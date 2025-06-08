namespace YieldReturn
{
    internal class Program
    {
        public static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield break;
            //yield return 3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Yield Return");


            foreach (var number in GetNumbers())
            {
                Console.WriteLine(number);
            }
        }
    }
}
