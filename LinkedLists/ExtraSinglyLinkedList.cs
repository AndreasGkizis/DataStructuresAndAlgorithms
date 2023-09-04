using System.Collections;
using System.Text;

namespace LinkedLists
{
    /// <summary>
    /// A singly linked list with only the bare essentials
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ExtraSinglyLinkedList<T> : IEnumerable
    {
        public T Head { get { return _head.Value; } }
        public T Tail { get { return _tail.Value; } }
        public int Count { get; private set; }
        private ExtraSinglyLinkedListNode<T> _head { get; set; }
        private ExtraSinglyLinkedListNode<T> _tail { get; set; }
        /// <summary>
        /// This will be every Node in my Linked List, the only thing it knows is its value and the next node.
        /// </summary>
        /// <typeparam name="T">The type of value stored in the node.</typeparam>
        public void AddHead(T value)
        {
            AddHead(new ExtraSinglyLinkedListNode<T>(value));
        }
        public void AddHead(ExtraSinglyLinkedListNode<T> node)
        {
            node.Next = _head;
            _head = node;
            if (_tail == null)
            {
                _tail = node;
            }
            Count++;

        }
        public void AddTail(T value)
        {
            AddTail(new ExtraSinglyLinkedListNode<T>(value));
        }
        public void AddTail(ExtraSinglyLinkedListNode<T> node)
        {
            _tail.Next = node;
            _tail = node;
            Count++;

        }
        public ExtraSinglyLinkedListNode<T>? Find(T value)
        {
            ExtraSinglyLinkedListNode<T> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return current;
                }
                else
                {
                    current = current.Next;
                }
            }
            return null;
        }
        public bool Contains(T value)
        {
            return Find(value) != null;
        }
        public bool RemoveHead()
        {
            if (_head != null)
            {
                _head = _head.Next;
                Count--;
                return true;
            }
            return false;
        }
        public bool RemoveTail()
        {
            if (_tail != null)
            {
                var current = _head;
                while (current.Next != _tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                _tail = current;
                Count--;
                return true;
            }
            return false;
        }
        public bool Remove(T value)
        {
            if (_head.Value.Equals(value))
            {
                return RemoveHead();
            }

            if (_tail.Value.Equals(value))
            {
                return RemoveTail();
            }
            ExtraSinglyLinkedListNode<T> previous = null;
            ExtraSinglyLinkedListNode<T> current = _head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            _tail = previous;
                            Count--;
                        }
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }
        public override string? ToString()
        {
            var sb = new StringBuilder();
            var currentNode = _head;

            while (currentNode != null)
            {
                sb.Append(currentNode.Value);
                if (currentNode.Next != null)
                {
                    sb.Append(" -> ");
                }
                currentNode = currentNode.Next;
            }
            return sb.ToString();
        }
        public IEnumerator GetEnumerator()
        {
            ExtraSinglyLinkedListNode<T> current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
    public class ExtraSinglyLinkedListNode<T>
    {
        public T Value { get; set; }
        public ExtraSinglyLinkedListNode<T>? Next { get; set; }
        public ExtraSinglyLinkedListNode(T value, ExtraSinglyLinkedListNode<T> nextNode = null)
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
