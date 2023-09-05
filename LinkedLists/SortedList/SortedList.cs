using LinkedLists.DoublyLinkedLists;
using System.Collections;
using System.Security;
using System.Text;

namespace LinkedLists.SortedList
{
    public class SortedList<T> : IEnumerable
        where T : IComparable<T>
    {
        public int Count { get; set; }
        public T? Head { get { return _head.Value; } }
        public T? Tail { get { return _tail.Value; } }
        private SortedLinkedListNode<T>? _head { get; set; }
        private SortedLinkedListNode<T>? _tail { get; set; }

        public void Add(T value)
        {
            Add(new SortedLinkedListNode<T>(value));
        }

        public void Add(SortedLinkedListNode<T> node)
        {
            // if it is empty of if the value is smaller than the head, add it as a head
            if (_head == null || _head.Value.CompareTo(node.Value) >= 0)
            {
                AddHead(node);
            }
            // if it is larger than the tail add it as a tail
            else if (_tail.Value.CompareTo(node.Value) < 0)
            {
                AddTail(node);
            }
            else
            {
                var insertBefore = _head;
                // find where to insert new node
                while (insertBefore.Value.CompareTo(node.Value) < 0)
                {
                    insertBefore = insertBefore.Next;
                }

                // insert new node in chain 
                node.Next = insertBefore;
                node.Previous = insertBefore.Previous;
                insertBefore.Previous.Next = node;
                insertBefore.Previous = node;
                Count++;
            }
        }


        private void AddHead(T value)
        {
            AddHead(new SortedLinkedListNode<T>(value));
        }
        private void AddHead(SortedLinkedListNode<T> node)
        {
            SortedLinkedListNode<T> temp = _head;
            _head = node;

            _head.Next = temp;

            if (Count == 0)
            {
                _tail = _head;
            }
            else
            {
                temp.Previous = _head;
            }
            Count++;
        }

        private void AddTail(T value)
        {
            AddTail(new SortedLinkedListNode<T>(value));
        }
        private void AddTail(SortedLinkedListNode<T> node)
        {
            if (Count == 0)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;
                node.Previous = _tail;
            }
            _tail = node;
            Count++;
        }


        public SortedLinkedListNode<T>? Find(T value)
        {
            var current = _head;
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
            if (Find(value) != null)
            {
                return true;
            }
            return false;
        }

        private bool RemoveHead()
        {
            if (_head != null)
            {
                _head = _head.Next;
                _head.Previous = null;
                return true;
            }
            return false;
        }

        private bool RemoveTail()
        {
            if (_tail != null)
            {
                _tail = _tail.Previous;
                _tail.Next = null;
                return true;
            }
            return false;
        }

        public bool RemoveNode(T value)
        {
            if (_head.Value.Equals(value))
            {
                RemoveHead();
                Count--;
                return true;
            }
            else if (_tail.Value.Equals(value))
            {
                RemoveTail();
                Count--;
                return true;
            }
            else
            {
                var nodeToRemove = Find(value);
                if (nodeToRemove != null)
                {
                    var previous = nodeToRemove.Previous;
                    previous.Next = nodeToRemove.Next;

                    var next = nodeToRemove.Next;
                    next.Previous = nodeToRemove.Previous;
                    Count--;
                    return true;
                }
                return false;
            }
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
            var current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        public IEnumerator GetReverseEnumerator()
        {
            var current = _tail;
            while (current != null)
            {
                yield return current.Value;
                current = current.Previous;
            }
        }
    }

}

