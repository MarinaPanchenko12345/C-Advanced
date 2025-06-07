namespace BoxingUnboxing
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 1;
            object b = a;
            int c = (int)b;

            //decimal d = (decimal)b; //InvalidCastExtention , unboxing must be int

            Console.ReadLine();
        }
    }
}
