using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    public class KonyvesPolc
    {

        private List<Konyv> _konyvek = new List<Konyv>();

        public KonyvesPolc(List<Konyv> konyvek)
        {
            this._konyvek = konyvek;
        }

        public KonyvesPolc()
        {

        }


        public void addKonyv(Konyv konyv)
        {
            _konyvek.Add(konyv);
        }

        public void removeKonyv(Konyv konyv)
        {
            if(_konyvek.Contains(konyv))
            {
                _konyvek.Remove(konyv);
            }
        }

        public int KonyvekSzama { 
           get { return _konyvek.Count; }
        }


        public int getKonyvekSzama()
        {
            return _konyvek.Count;
        }

    }
}
