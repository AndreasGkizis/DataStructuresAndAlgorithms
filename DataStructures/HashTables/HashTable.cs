using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTables
{
    public class HashTable<TKey, TValue>
    {
        // when we consider the table full, so it has to grow
        const double _fillFactor = 0.75;
        // when it is considered full, hwo much it will grow by 
        const double _growFactor = 1.5;
        int _count;
        private HashTableArray<TKey, TValue> _array;

        public IEnumerable<TKey> Keys;
        public IEnumerable<TValue> Values;

        public void Clear() { }
        public void Add() { }

        public TValue this[TKey key]
        {
            _array.

        }


    }
}
