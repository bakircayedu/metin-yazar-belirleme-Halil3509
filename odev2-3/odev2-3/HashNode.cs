using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_3
{
    public class HashNode
    {
        public String Key { get; set; }
        public int hash { get; set; }
        public char durum { get; set; }

        public HashNode Next;
        public HashNode(string key)
        {
            this.Key = key;
            this.Next = null;
            this.durum = 'b';
        }
    }
}
