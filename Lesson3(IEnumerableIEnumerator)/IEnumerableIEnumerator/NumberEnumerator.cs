
using System.Collections;

namespace IEnumerableIEnumerator
{
    public class NumberEnumerator : IEnumerator<int>
    {
        private readonly int _start;
        private readonly int _count;
        private  int _currentIndex;
        

        public NumberEnumerator(int start, int count)
        {
            _start = start;
            _count = count;
            _currentIndex = -1;
        }

        public int Current
        {
            get
            {
                if(_currentIndex< 0 || _currentIndex >= _count)
                    throw new InvalidOperationException("Enumerator is in an invalid state");

                return _start + _currentIndex;
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if(_currentIndex+1 < _count)
            {
                _currentIndex++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}