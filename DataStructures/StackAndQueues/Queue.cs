using DataStructures.Deque;

// First in last out 
namespace DataStructures.Queue;

public class Queue<T>
{
    readonly Deque<T> store = new();
    public int Count { get { return store.Count; } }


    public void Enqueue(T value)
    {
        store.EnqueueHead(value);
    }
    public T Dequeue()
    {
        return store.DequeueHead();
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
