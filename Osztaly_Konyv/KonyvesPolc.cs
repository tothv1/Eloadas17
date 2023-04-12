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
        private Dictionary<string, int> _konyvekDic = new Dictionary<string, int>();

        public KonyvesPolc(List<Konyv> konyvek)
        {
            this._konyvek = konyvek;
        }

        public KonyvesPolc()
        {

        }

        //-1 ha nincs benne
        public int getBookIndex(Konyv search)
        {
            for (int i = 0; i < _konyvek.Count; i++)
            {
                if (_konyvek[i].Equals(search))
                {
                    return i;
                }
            }
            return -1;
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

        internal List<Konyv> getKonyvesPolc()
        {
            return _konyvek;
        }
        public Dictionary<string, int> getKonyvesDict()
        {
            return _konyvekDic;
        }

        public void addKonyvToDict(string k, int v)
        {
            _konyvekDic.Add(k, v);
        }
    }
}
