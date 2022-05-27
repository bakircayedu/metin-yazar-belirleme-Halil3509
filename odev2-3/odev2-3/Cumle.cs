using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_3
{
    public class Cumle : IStack
    {

        public int top { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Cumle()
        {
            this.top = 0;
        }

        LinkedLİstProcess ll = new LinkedLİstProcess();

        public void Push(Kelime kelime)
        {
            ll.InsertLast(kelime.OrjinalKisim);
            top = ll.size;
        }

        public string Pop()
        {
            top = ll.size;
            return ll.DeleteLast();        
        }

        public string Peek()
        {
            return ll.Peek();
        }

        public bool IsEmpty()
        {
            return ll.size == 0;
        }
        public String GetElement(int index)
        {
            return ll.GetElement(index);
        }

        public int Length()
        {
            return top;
        }

        public Kelime GetElementKelime(int index)
        {
            return ll.GetElemntKelime(index);
        }
    }
}
