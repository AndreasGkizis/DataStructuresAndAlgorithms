using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DoublyLinkedList
{
    public class DoublyLinkedListNode<T>
    {
        public T Value { get; set; }
        public DoublyLinkedListNode<T>? Next { get; set; }
        public DoublyLinkedListNode<T>? Previous { get; set; }
        public DoublyLinkedListNode(T value)
        {
            Value = value;
            //Next = nextNode;
        }
        public override string? ToString()
        {
            return Value.ToString();
        }
    }
}
