using System.Collections;
using DataStructures.DoublyLinkedList;

namespace DataStructures.Deque;

public class Deque<T> : IEnumerable<T>
{
    readonly PureDoublyLinkedList<T> store = new();

    // overload so you can add a node or just a value
    public void EnqueueHead(T value)
    {
        store.AddHead(new DoublyLinkedListNode<T>(value));
    }
    public void EnqueueHead(DoublyLinkedListNode<T> value)
    {
        store.AddHead(value);
    }
    // overload so you can add a node or just a value
    public void EnqueueTail(T value)
    {
        store.AddTail(new DoublyLinkedListNode<T>(value));
    }
    public void EnqueueTail(DoublyLinkedListNode<T> value)
    {
        store.AddTail(value);
    }

    public T DequeueTail()
    {
        if (store.Count > 0)
        {
            T removedTail = store.Tail;
            store.RemoveTail();
            return removedTail;
        }
        throw new InvalidOperationException();
    }

    public T DequeueHead(){
        if(Count>0){
            T removedHead = store.Head;
            store.RemoveHead();
            return removedHead;
        }
        throw new InvalidOperationException();
    }
    /// <summary>
    /// Retrieves the value at the head of the data store without removing it.
    /// </summary>
    /// <returns>
    /// A tuple containing a boolean indicating whether the head element exists (<typeparamref name="bool"/>: true) or not (<typeparamref name="bool"/>: false),
    /// and the value at the head of the data store of type <typeparamref name="T"/>.
    /// </returns>
    public (bool, T?) PeekHead()
    {
        return store.Head != null ? (true, store.Head) : (false, store.Head);
    }
    public (bool, T?) PeekTail()
    {
        return store.Tail != null ? (true, store.Tail) : (false, store.Tail);
    }

    public int Count
    {
        get { return store.Count; }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return store.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
