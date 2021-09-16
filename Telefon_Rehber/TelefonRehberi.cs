using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehber
{
    public class TelefonRehberi
    {
        public List<Kayıt> _tel_list;
        public TelefonRehberi()
        {
            _tel_list = new List<Kayıt>();
        }
        public void Ekle(Kayıt k)
        {
            _tel_list.Add(k);
        }
        public void Sil(int pos)
        {
            _tel_list.RemoveAt(pos);
        }
        public void Guncelle(int pos,Kayıt k)
        {
            _tel_list[pos] = k;
            
        }
        public Kayıt getKayıt(int pos)
        {
            return _tel_list[pos];
        }
    }
}
