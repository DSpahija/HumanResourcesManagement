using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace MenaxhimiIBurimeveNjerezore
{
    public class Punetori : Personi
    {
        //Pozita e punes - profesioni
        public static int _IDPunetori;
        public string Kualifikimi { get; set;}
        public string NrTelefonit { get; set; }
        private Departamenti _Departamenti = new Departamenti();
        public string Departamenti { get; set; }
        public double Pensioni { get; set; }
        public double RrogaNetto { get; set; }
        public double RrogaBruto;
        private double _Tatimi { get; set; }
        private double _RrogaParaTatimit;
        public static string IDPunetori;
        public string Datelindja { get; set; }

        public double RrogaParaTatimit
        {
            get
            {
                return _RrogaParaTatimit;
            }
            set
            {
                _RrogaParaTatimit = RrogaBruto - (RrogaBruto * Pensioni/100);
            }
        }

        public double Tatimi
        {
            get { return _Tatimi; }
            set
            {
                if (RrogaParaTatimit < 80)
                {
                    _Tatimi = 0;
                }
                if (RrogaParaTatimit >= 80 && RrogaParaTatimit < 250)
                {
                    _Tatimi = (RrogaParaTatimit -80)*4/100;
                }
                if (RrogaParaTatimit >= 250 && RrogaParaTatimit < 450)
                {
                    _Tatimi = (RrogaParaTatimit - 250)*8 /100 +6.8;
                }
                if(RrogaParaTatimit >= 450)
                {
                    _Tatimi = ((RrogaParaTatimit - 450)*10/ 100) + 16 + 6.8;
                }
            }
        }

        public override string IDMetode()
        {
            _IDPunetori = Id;
            if (_IDPunetori < 10 && _IDPunetori > 0)
            {
                FullID = "00"+_IDPunetori + "_Punetori";
                IDPunetori = FullID;
            }
            if (_IDPunetori < 100 && _IDPunetori > 9)
            {
                FullID = "0" + _IDPunetori + "_Punetori";
                IDPunetori = FullID;
            }
            if (_IDPunetori > 99)
            {
                    FullID =_IDPunetori + "_Punetori";
                    IDPunetori = FullID;
            }

            return IDPunetori;
        }

        public override string ToString()
        {
            return Emri + " " + Mbiemri; 
        }

        public string tostring()
        {
            return IDPunetori;
        }

        public string emri()
        {
            return Emri;
        }

        public double LlogaritjaRrogaNetto(double rroga, double tatimi)
        {
            RrogaParaTatimit = rroga;
            Tatimi = tatimi;
            RrogaNetto = RrogaParaTatimit - Tatimi;
            return RrogaNetto;
        }

        public Punetori(string idPunetori, string emri, string mbiemri, DateTime datelindja, string nrTel, string kualifikimi, double rrogaBruto, double pensioni, double rrogaNetto, double tatimi, string departamenti)
        {
            //Regjistrimi i punetorit
            _Departamenti.EmriDepartamentit = departamenti;
            Departamenti = _Departamenti.EmriDepartamentit;
            IDPunetori = idPunetori;
            Emri = emri;
            Mbiemri = mbiemri;
            Datelindja = datelindja.Date.ToString("dd/MM/yyyy");
            NrTelefonit = nrTel;
            Kualifikimi = kualifikimi;
            Pensioni = pensioni;
            _Tatimi = tatimi;
            RrogaBruto = rrogaBruto;
            RrogaNetto = rrogaNetto;
        }

        //Llogaritja e pages
        public Punetori(double rrogaBruto, double pensioni)
        {
            RrogaBruto = rrogaBruto;
            Pensioni = pensioni;
        }
        public static Punetori punetori;

        public static Punetori Kontrata()
        {
            punetori.Emri = null;
            return punetori;
        }

        public Punetori()
        {
            //Default
        }
    }
}
