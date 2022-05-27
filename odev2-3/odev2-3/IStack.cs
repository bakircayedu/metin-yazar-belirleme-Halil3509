using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_3
{
    public interface IStack
    {
        void Push(Kelime kelime);
        String Pop();
        String Peek();
        Boolean IsEmpty();
        int top { get; set; }
        String GetElement(int index);
        int Length();
        Kelime GetElementKelime(int index);
    }
}
