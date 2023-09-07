using DataStructures.SinglyLinkedLists;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DoublyLinkedLists
{
    public class PureDoublyLinkedList<T> : IEnumerable
    {
        public int Count { get; set; }
        public T? Head { get { return _head.Value; } }
        public T? Tail { get { return _tail.Value; } }
        private DoublyLinkedListNode<T>? _head { get; set; }
        private DoublyLinkedListNode<T>? _tail { get; set; }

        public void AddHead(T value)
        {
            AddHead(new DoublyLinkedListNode<T>(value));
        }
        public void AddHead(DoublyLinkedListNode<T> node)
        {
            DoublyLinkedListNode<T> temp = _head;
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

        public void AddTail(T value)
        {
            AddTail(new DoublyLinkedListNode<T>(value));
        }
        public void AddTail(DoublyLinkedListNode<T> node)
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


        public DoublyLinkedListNode<T>? Find(T value)
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

        public bool RemoveHead()
        {
            if (_head != null)
            {
                _head = _head.Next;
                _head.Previous = null;
                return true;
            }
            return false;
        }

        public bool RemoveTail()
        {
            if(_tail != null)
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
            }else if (_tail.Value.Equals(value))
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
            var current =  _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }   
        public IEnumerator GetReverseEnumerator()
        {
            var current =  _tail;
            while (current != null)
            {
                yield return current.Value;
                current = current.Previous;
            }
        }
    }
}
