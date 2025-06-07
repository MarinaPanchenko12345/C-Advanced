using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IEnumerableIEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IEnumerable IEnumerator");

            IEnumerable<int> sequence = new NumberSequence(start: 10, count: 3);

            foreach (var number  in sequence)
            {
                Console.WriteLine(number);
            }
        }
    }
}
