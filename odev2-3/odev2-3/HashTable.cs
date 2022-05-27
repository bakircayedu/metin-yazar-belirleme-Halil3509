using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_3
{
    public abstract class HashTable
    {
        public HashNode[] HashTableArray;

        public int Table_Size;
        public abstract void Add(String key);
        public abstract int ReturnASCII(String key);
        public abstract void Remove(int index);
        public abstract string DisplayHashTable();
        public abstract string GetHashNode(int index);
    }
}
