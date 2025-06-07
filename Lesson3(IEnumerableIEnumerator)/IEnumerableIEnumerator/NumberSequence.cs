
using System.Collections;

namespace IEnumerableIEnumerator
{
    public class NumberSequence : IEnumerable<int>
    {
        
        private readonly int _start;
        private readonly int _count;

        public NumberSequence(int start, int count)
        {
            _start = start;
            _count = count;
        }
        public IEnumerator<int> GetEnumerator()
        {
           return new NumberEnumerator(_start,_count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}