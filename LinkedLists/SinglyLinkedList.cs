﻿using System.Text;

namespace LinkedLists
{
    public class SinglyLinkedList<T>
    {
        public T Head { get { return _head.Value; } }
        public T Tail { get { return _tail.Value; } }
        // First Node
        private SinglyLinkedListNode<T> _head { get; set; }
        // Last Node
        private SinglyLinkedListNode<T> _tail { get; set; }
        /// <summary>
        /// This will be every Node in my Linked List, the only thing it knows is its value and the next node.
        /// </summary>
        /// <typeparam name="T">The type of value stored in the node.</typeparam>
        public void AddHead(T item)
        {
            SinglyLinkedListNode<T> nodeToAdd = new SinglyLinkedListNode<T>(item);
            nodeToAdd.Next = _head;
            _head = nodeToAdd;
            if (_tail == null)
            {
                _tail = nodeToAdd;
            }
        }

        public void AddTail(T item)
        {
            SinglyLinkedListNode<T> nodeToAdd = new SinglyLinkedListNode<T>(item);
            //var currentTail = _tail;
            _tail.Next = nodeToAdd;
            _tail = nodeToAdd;

        }

        public SinglyLinkedListNode<T>? Find(T value)
        {
            SinglyLinkedListNode<T> current = _head;

            while (current != null)
            {
                if ( current.Value.Equals(value))
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
            return Find(value) != null ; 
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
    }
    public class SinglyLinkedListNode<T>
    {
        public T Value { get; set; }
        public SinglyLinkedListNode<T> Next { get; set; }
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