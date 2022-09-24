﻿namespace BigO.DataStructures.Abstractions
{
    public interface IPriorityQueue<T>
    {
        void Enqueue(T p);
        void Remove(int i);
        T Dequeue();
        T Peek();
        void ChangePriority(int i, T p);
    }
}
