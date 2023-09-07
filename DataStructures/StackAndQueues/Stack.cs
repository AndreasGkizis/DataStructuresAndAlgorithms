using DataStructures.Deque;

namespace DataStructures.Stack;

// First in First out 
public class Stack<T>
{
    readonly Deque<T> store = new();
    public int Count { get { return store.Count; } }
    public void Push(T value)
    {
        store.EnqueueHead(value);
    }
    public T Pop()
    {
        return store.DequeueTail();
    }
    public T Peek()
    {
        (bool headExists, T headNode) currentHead = store.PeekHead();
        if (currentHead.headExists)
        {
            return currentHead.headNode;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }
}
