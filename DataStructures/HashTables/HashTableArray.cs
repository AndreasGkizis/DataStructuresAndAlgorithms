using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
            for (int i = 0; i < arrayCapacity; i++)
            {
                _array[i] = new HashTableArrayNode<TKey, TValue>();
            }
        }
        // public bool TryGetValue(TKey key, out TValue value)
        // {
        //     return _array[GetIndex(key)].TryGetValue(key, out value);
        // }

        // you can use anything for an index, so whatever it is after getting a hash code and devided it will end up returning a number 
        // that number will be used as the position in the array
        private int GetIndex(TKey key)
        {
            return Math.Abs(key.GetHashCode() % Capacity);
        }

        public void Add(TKey key, TValue value)
        {
            _array[GetIndex(key)].Add(key, value);
        }


        internal bool TryGetKey(TKey key)
        {
            var keyHashedToIndex = GetIndex(key);
            var arraynode = _array[keyHashedToIndex];
            if (_array[keyHashedToIndex].itemsCount >= 1)
            {
                return _array[keyHashedToIndex].ContainsKey(key);

            }
            return false;

        }
    }
}
