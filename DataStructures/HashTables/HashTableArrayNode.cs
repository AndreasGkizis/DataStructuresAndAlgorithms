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
        // in each hashed table there are Nodes inside the array, they have linked lists inside
        ExtraSinglyLinkedList<HashTableNodePair<TKey, TValue>> _items;
        public int itemsCount
        {
            get
            {
                if (_items is not null)
                {
                return _items.Count;
                    
                }else
                {
                    return 0;
                }
            }
        }
        public HashTableArrayNode()
        {

        }
        public HashTableArrayNode(TKey key, TValue Value)
        {

        }
        public void Add(TKey key, TValue value)
        {
            if (_items == null)
            {
                _items = new ExtraSinglyLinkedList<HashTableNodePair<TKey, TValue>>();
            }

            var node = new HashTableNodePair<TKey, TValue>(key, value);
            _items.AddHead(node);
        }

        public bool ContainsKey(TKey key)
        {
            bool result = false;
            foreach (HashTableNodePair<TKey, TValue> pair in _items)
            {
                if (key.Equals(pair.Key))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        // internal bool TryGetValue<TKey, TValue>(TKey? key, out TValue? value)
        // {
        //    var result =_items.Find(value);
        //    value =result;
        //    return result==null? false:true;
        // }
    }
}
