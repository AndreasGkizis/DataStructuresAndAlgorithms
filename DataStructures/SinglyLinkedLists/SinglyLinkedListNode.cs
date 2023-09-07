namespace DataStructures.SinglyLinkedLists
{
    /// <summary>
    /// This will be every Node in my Linked List, the only thing it knows is its value and the next node.
    /// </summary>
    /// <typeparam name="T">The type of value stored in the node.</typeparam>
    public class SinglyLinkedListNode<T>
    {
        public T Value { get; set; }
        public SinglyLinkedListNode<T>? Next { get; set; }
        public SinglyLinkedListNode(T value, SinglyLinkedListNode<T> nextNode = null)
        {
            Value = value;
            Next = nextNode;
        }
        public override string? ToString()
        {
            return Value.ToString();
        }
    }

}
