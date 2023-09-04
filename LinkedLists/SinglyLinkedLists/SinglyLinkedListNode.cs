namespace LinkedLists.SinglyLinkedLists
{
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
