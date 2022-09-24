using BigO.DataStructures.Abstractions;

namespace BigO.DataStructures
{
    public class StackMax<T> : IStack<T> where T : IComparable
    {
        private readonly Stack<T> _stack;
        private readonly Stack<T> _stackMax;

        public bool IsEmpty => _stack.IsEmpty;

        public StackMax()
        {
            _stack = new Stack<T>();
            _stackMax = new Stack<T>();
        }
        public void Push(T item)
        {
            var max = item;
            if(!_stackMax.IsEmpty)
            {
                var lastMax = _stackMax.Peek();
                if (max.CompareTo(lastMax) < 0) max = lastMax; //max < lastMax
            }

            _stack.Push(item);
            _stackMax.Push(max);
        }
        public T Pop()
        {
            _stackMax.Pop();
            return _stack.Pop();
        }

        public T Peek()
        {
            return _stack.Peek();
        }

        public T Max()
        {
            return _stackMax.Peek();
        }
    }
}
