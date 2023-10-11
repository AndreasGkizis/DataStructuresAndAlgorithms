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
        ExtraSinglyLinkedList<HashTableNodePair<TKey, TValue>> _items;

        public HashTableArrayNode(TKey key, TValue Value)
        {
            
        }
        public void Add(TKey key, TValue value){
            var node = new HashTableNodePair<TKey,TValue>(key, value);
            _items.AddTail(node);
        }
        // internal bool TryGetValue<TKey, TValue>(TKey? key, out TValue? value)
        // {
        //    var result =_items.Find(value);
        //    value =result;
        //    return result==null? false:true;
        // }
    }
}
