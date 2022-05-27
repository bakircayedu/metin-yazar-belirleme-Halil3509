using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_3
{
    public class Kelime
    {
        public String OrjinalKisim { get; set; }
        public int MetinKacinciCumleSayisi { get; set; }
        public int CumleKacincıSayisi { get; set; }
        public String OnIslenmisHali { get; set; }
        public int KullanimSikligi { get; set; }

        public Kelime Next;

    }
}
