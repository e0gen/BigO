namespace BigO.DataStructures.Abstractions
{
    public interface IStack<T>
    {
        bool IsEmpty { get; }
        void Push(T item);
        T Pop();
        T Peek();
    }
}
