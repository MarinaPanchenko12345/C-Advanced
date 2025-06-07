namespace Generics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Without Generics");
            int a = 1;
            int b = 5;

            Console.WriteLine($"a = {a}\t b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a}\t b = {b}");

            Console.ReadLine();
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
