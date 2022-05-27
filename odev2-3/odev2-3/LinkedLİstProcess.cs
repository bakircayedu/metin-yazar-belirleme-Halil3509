using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_3
{
    public class LinkedLİstProcess : LİnkedLİst
    {
        public LinkedLİstProcess()
        {
            Head = null;
        }
        
        public override String DeleteLast()
        {
            if(Head == null)
            {
                throw new Exception("Silinecek Kelime yoktur.");
            }
            else
            {
                Kelime temp = Head;
                Kelime ondekiKelime = null;
                while (temp.Next != null)
                {
                    if(temp.Next.Next == null)
                    {
                        ondekiKelime = temp;
                    }
                    temp = temp.Next;
                }
                ondekiKelime.Next = null;
                temp = null;
                size--;
                return temp.OrjinalKisim;
            }
            
        }

        public override string GetElement(int index)
        {
            int count = 1;
            Kelime temp = Head;
            while(true)
            {
                temp = temp.Next;
                count++;
                if (count == index)
                    break;
            }
            return temp.OnIslenmisHali;
        }

        public override Kelime GetElemntKelime(int index)
        {
            int count = 1;
            Kelime temp = Head;
            while (true)
            {
                temp = temp.Next;
                count++;
                if (count == index)
                    break;
            }
            return temp;
        }

        public override void InsertFirst(String kelime)
        {
            Kelime eklenecekKelime = new Kelime
            {
                OrjinalKisim = kelime
            };
            if(Head == null)
            {
                Head = eklenecekKelime;
            }
            else
            {
                eklenecekKelime.Next = Head;
                Head = eklenecekKelime;
            }
            size++;
        }

        public override void InsertLast(String kelime)
        {
            Kelime eklenecekKelime = new Kelime
            {
                OrjinalKisim = kelime
            };
            Kelime temp = Head;
            
            if(Head == null)
            {
                InsertFirst(kelime);
            }
            else
            {
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = eklenecekKelime;
                eklenecekKelime.Next = null;
                size++;

            }
            
        }

        public override String Peek()
        {
            Kelime temp = Head;
            while(temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp.OrjinalKisim;
        }

       
    }
}
