using DataStructures.SinglyLinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTables
{
    public class HashTableArrayNode<TKey, TValue>
    {
        // in each hashed table there are Nodes, they have linked lists inside
        ExtraSinglyLinkedList<HashTableArrayNode<TKey, TValue>> _items;
    }
}
