using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_3
{
    public class HeapProcesses : Heap
    {
        public HeapProcesses(int size)
        {
            this.currentSize = 0;
            this.maxSize = size;
            this.headArray = new Kelime[maxSize];
        }
        public override string DisplayHeap()
        {
            String result = "";
           for(int i = 0; i < headArray.Length; i++)
            {
                result += headArray[i].OnIslenmisHali + " " + headArray[i].KullanimSikligi + " - ";
            }
            return result;
        }

        public override void Insert(Kelime heapDugum)
        {
            try
            {
                if (currentSize == maxSize)
                    throw new Exception("Dolu Dizi");
                headArray[currentSize] = heapDugum;
                MoveToUp(currentSize++);
            }
            catch(Exception er)
            {
                throw new Exception("Hata:" + er.Message);
            }

        }

        public override bool IsEmpty()
        {
            return currentSize == 0;
        }

        public override void MoveToDown(int index)
        {
            int largerChild;
            Kelime top = headArray[index];
            while(index< currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if (rightChild < currentSize && headArray[leftChild].KullanimSikligi < headArray[rightChild].KullanimSikligi)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.KullanimSikligi >= headArray[largerChild].KullanimSikligi)
                    break;
                headArray[index] = headArray[largerChild];
                index = largerChild;
            }
            headArray[index] = top;
        }

        public override void MoveToUp(int index)
        {
            int parent;
            if (index % 2 == 0)
                 parent = index / 2;
            else
                 parent = (index - 1) / 2;
            Kelime heapDugum = headArray[index];
            while(index > 0 && headArray[parent].KullanimSikligi < heapDugum.KullanimSikligi)
            {
                headArray[index] = headArray[parent];
                index = parent;
                if (index % 2 == 0)
                    parent = index / 2;
                else
                    parent = (index - 1) / 2;
            }
            headArray[index] = heapDugum;
        }

        public override Kelime RemoveMax()
        {
            Kelime kelime = headArray[0];
            headArray[0] = headArray[--currentSize];
            MoveToDown(0);
            return kelime;
        }

        public override String Sort(Kelime[] butunKelimeler, int adet)
        {
            HeapProcesses h = new HeapProcesses(butunKelimeler.Length);
            int[] sorted = new int[butunKelimeler.Length];
            foreach (var item in butunKelimeler)
                h.Insert(item);
            int i = 0;
            int index = 0;
            while (!h.IsEmpty() && index < adet)
            {
                sorted[i++] = h.RemoveMax().KullanimSikligi;
                index++;
            }
            String result = "";
            for(int j = 0; j < sorted.Length; j++)
            {
                result += sorted[j] + "-";
            }
            return result;
            
        }
    }
}
