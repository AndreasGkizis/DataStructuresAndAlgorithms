using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTables
{
    internal class HashTableArray<TKey, TValue>
    {
        HashTableArrayNode<TKey, TValue>[] _array;

        public HashTableArray(int arrayCapacity)
        {
            _array = new HashTableArrayNode<TKey, TValue>[arrayCapacity];
        }
        public bool TryGetValue(TKey key, out TValue value)
        {
            return (true, TValue);
        }
    }
}
