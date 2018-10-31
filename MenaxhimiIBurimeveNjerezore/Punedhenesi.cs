using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiIBurimeveNjerezore
{
    public class Punedhenesi : Personi
    {
        public static int _IDPunedhenesi;
        public Departamenti Departamenti;
        public static string IDPunedhenesi;

        public Punedhenesi()
        {
            //Default
        }

        public override string ToString()
        {
            return Emri + " " + Mbiemri;
        }

        public Punedhenesi(string emri, string mbiemri)
        {
            Emri = emri;
            Mbiemri = mbiemri;
        }

        public override string IDMetode()
        {
            Id = 1;
            _IDPunedhenesi = Id;
            FullID = _IDPunedhenesi + "_Punedhenes";
            IDPunedhenesi = FullID;
            return IDPunedhenesi;
        }
    }
}
