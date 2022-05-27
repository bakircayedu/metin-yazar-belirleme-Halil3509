using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_3
{
    public class Metin
    {
        public List<Cumle> cumleler = new List<Cumle>();
        
        public void add(Cumle cumle)
        {
            cumleler.Add(cumle);
        }

        public int Length()
        {
            return cumleler.Count();
        }

    }
}
