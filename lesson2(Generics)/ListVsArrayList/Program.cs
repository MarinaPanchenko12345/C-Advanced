using System.Collections;

namespace ListVsArrayList
{

    public class Lists
    {
        public void ArrayList()
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 1000; i++)
            {
                arrayList.Add(i);
            }
        }
        public void List()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ListVsArrayList");



        }
    }
}
