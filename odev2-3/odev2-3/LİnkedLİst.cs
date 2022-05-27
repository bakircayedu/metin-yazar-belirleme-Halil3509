using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_3
{
    public abstract class LİnkedLİst
    {
        public Kelime Head;
        public int size = 0;
        public abstract void InsertLast(String kelime);
        public abstract String DeleteLast();
        public abstract String Peek();
        public abstract void InsertFirst(String kelime);
        public abstract String GetElement(int index);
        public abstract Kelime GetElemntKelime(int index);
    }
}
