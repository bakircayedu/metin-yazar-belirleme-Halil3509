using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2_3
{
    public class HashTableProcesses : HashTable
    {
        public HashTableProcesses(int tableSize, int maxSize)
        {
            this.Table_Size = tableSize;
            this.HashTableArray = new HashNode[maxSize];
        }
        public override void Add(string key)
        {
            int hash = ReturnASCII(key);
            HashNode node = new HashNode(key);
            node.hash = hash;
            if(HashTableArray[hash].durum == 'b' || HashTableArray[hash].durum == 's')
            {
                HashNode Head;
                node.durum = 'd';
                Head = node;
                HashTableArray[hash] = node;
            }
            else
            {
                HashNode temp = HashTableArray[hash];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
                node.Next = null;
            }
        }

        public override string DisplayHashTable()
        {
            String result = "";
            for(int i = 0; i < HashTableArray.Length; i++)
            {
                if(HashTableArray[i].durum == 'd')
                {
                    HashNode temp = HashTableArray[i];
                    while(temp.Next != null)
                    {
                        result += temp.Key + "-";
                        temp = temp.Next;
                    }
                }
            }
            return result;
        }

        public override string GetHashNode(int index)
        {
            String result = "";
            if(HashTableArray[index].durum == 'd')
            {
                HashNode temp = HashTableArray[index];
                while(temp.Next != null)
                {
                    result += temp.Key + "-";
                    temp = temp.Next;
                }
            }
            else
            {
                MessageBox.Show("Bu indiste bir değer yoktur");
            }
            return result;
        }

        public override void Remove(int index)
        {
            if(HashTableArray[index].durum == 'd')
            {
                HashTableArray[index] = null;
            }
        }

        public override int ReturnASCII(string key)
        {
            int hashVal = 0;
            for(int i = 0;i< key.Length; i++)
            {
                hashVal += key[i];
            }
            return hashVal % Table_Size;
        }
    }
}
