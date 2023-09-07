using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SortedList
{
    public class SortedLinkedListNode<T> where T: IComparable<T>
    {
        public T Value { get; set; }
        public SortedLinkedListNode<T>? Next { get; set; }
        public SortedLinkedListNode<T>? Previous { get; set; }
        public SortedLinkedListNode(T value)
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
