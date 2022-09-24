using System.Collections;

namespace BigO.DataStructures
{
    /// <summary>
    /// One way enumerable linked list implementation
    /// </summary>
    public class SingleLinkedList<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        public SingleLinkedListNode<T>? Head { get; private set; }
        public SingleLinkedListNode<T>? Tail { get; private set; }

        public SingleLinkedList()
        {
        }

        public SingleLinkedList(IEnumerable<T> enumerable)
        {
            if (enumerable == null)
                throw new ArgumentNullException(nameof(enumerable));

            foreach (T item in enumerable)
            {
                InsertLast(item);
            }
        }
        public void InsertFirst(T item)
        {
            if (Head == null)
                InternalInsertToEmptyList(item);
            else
                InternalInsertBeforeHead(item);
        }

        public void InsertLast(T item)
        {
            if(Tail == null)
                InternalInsertToEmptyList(item);
            else
                InternalInsertAfterNode(Tail, item);
        }

        public void InsertAfter(SingleLinkedListNode<T> node, T item)
        {
            ValidateNode(node);
            InternalInsertAfterNode(node, item);
        }

        public void DeleteFirst()
        {
            if (Head == null)
                throw new InvalidOperationException();
            InternalRemoveNode(Head);
        }
        public void DeleteLast()
        {
            if (Tail == null)
                throw new InvalidOperationException();
            InternalRemoveNode(Tail);
        }

        public void Delete(SingleLinkedListNode<T> node)
        {
            ValidateNode(node);
            InternalRemoveNode(node);
        }

        private void InternalInsertToEmptyList(T item)
        {
            Head = Tail = new SingleLinkedListNode<T>(this, item);
            Count++;
        }
        private void InternalInsertAfterNode(SingleLinkedListNode<T> node, T item)
        {
            var newNode = new SingleLinkedListNode<T>(this, item);
            if (node == Tail)
            {
                //newNode.Next = newNode;
                Tail = newNode;
                
            }
            else //if (node.Next != node)
            {
                newNode.Next = node.Next;
            }
            node.Next = newNode;
            Count++;
        }

        private void InternalInsertBeforeHead(T item)
        {
            var newNode = new SingleLinkedListNode<T>(this, item)
            {
                Next = Head
            };
            Head = newNode;
            Count++;
        }

        internal SingleLinkedListNode<T>? InternalFindPreviousNode(SingleLinkedListNode<T> node)
        {
            if (Head == null) return null;

            var current = Head;
            while (current != null)
            {
                if (current.Next == node)
                    return current;

                current = current.Next;
            }
            return current;
        }

        internal void InternalRemoveNode(SingleLinkedListNode<T> node)
        {
            if (node == Head)
                if (node == Tail)
                    Head = Tail = null;
                else
                    Head = Head.Next;
            else
            {
                var prev = InternalFindPreviousNode(node);
                if (node == Tail)
                {
                    prev!.Next = null;
                    Tail = prev;
                }
                else
                {
                    prev!.Next = node.Next;
                }
            }
            node.Invalidate();
            Count--;
        }

        internal void ValidateNode(SingleLinkedListNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (node.List != this)
            {
                throw new InvalidOperationException();
            }
        }

        public Enumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public struct Enumerator : IEnumerator<T>
        {
            private T _current;
            private readonly SingleLinkedList<T> _list;
            private SingleLinkedListNode<T>? _node;
            private int _index;
            public Enumerator(SingleLinkedList<T> list)
            {
                _list = list;
                _node = list.Head;
                _current = default;
                _index = 0;
            }
            public T Current => _current;

            object? IEnumerator.Current
            {
                get
                {
                    if (_index == 0 || (_index == _list.Count + 1))
                    {
                        throw new InvalidOperationException();
                    }

                    return Current;
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (_node == null)
                {
                    _index = _list.Count + 1;
                    return false;
                }

                ++_index;
                _current = _node.Value;
                if (_node == _node.Next)
                    _node = null;
                else
                    _node = _node.Next;
                return true;
            }

            public void Reset()
            {
                _current = default;
                _node = _list.Head;
                _index = 0;
            }
        }
    }

    public class SingleLinkedListNode<T>
    {
        public SingleLinkedList<T>? List { get; private set; }
        public SingleLinkedListNode<T>? Next { get; set; }
        public T Value { get; set; }
        public SingleLinkedListNode(SingleLinkedList<T> list, T value)
        {
            List = list;
            Value = value;
        }

        internal void Invalidate()
        {
            List = null;
            Next = null;
        }
    }
}
