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
        public (bool IsValueFound, TValue Value)  TryGetValue(TKey key)
        {
            return (true, TValue );
        }
    }
}
