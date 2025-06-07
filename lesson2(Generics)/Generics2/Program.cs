namespace Generics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("With Generics");
            int a = 1;
            int b = 5;

            Console.WriteLine($"a = {a}\t b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a}\t b = {b}");

            Console.ReadLine();
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}

