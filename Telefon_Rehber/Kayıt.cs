using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehber
{
    public class Kayıt
    {
        public string adisoyadı;
        public string telno;
        public Kayıt(string ads,string tn)
        {
            adisoyadı = ads;
            telno = tn;
        }
        public override string ToString()
        {
            return adisoyadı + "-------------->" + telno;
        }
    }
}
