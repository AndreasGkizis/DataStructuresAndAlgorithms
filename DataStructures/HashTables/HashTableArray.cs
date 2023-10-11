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
        public int Capacity { get { return _array.Length; } }

        public HashTableArray(int arrayCapacity)
        {
            _array = new HashTableArrayNode<TKey, TValue>[arrayCapacity];
        }
        // public bool TryGetValue(TKey key, out TValue value)
        // {
        //     return _array[GetIndex(key)].TryGetValue(key, out value);
        // }

        private int GetIndex(TKey key)
        {
            return Math.Abs(key.GetHashCode() % Capacity);
        }
    }
}
