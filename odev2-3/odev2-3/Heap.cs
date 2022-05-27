using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_3
{
    public abstract class Heap
    {
        public int currentSize { get; set; }
        public Kelime[] headArray { get; set; }
        public int maxSize { get; set; }
        public abstract String DisplayHeap();
        public abstract void Insert(Kelime heapDugum);
        public abstract Boolean IsEmpty();
        public abstract void MoveToUp(int index);
        public abstract Kelime RemoveMax();
        public abstract void MoveToDown(int index);
        public abstract String Sort(Kelime[] kelimeler, int adet);
    }
}
