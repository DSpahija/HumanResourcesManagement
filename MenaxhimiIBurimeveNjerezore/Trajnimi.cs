using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiIBurimeveNjerezore
{
    public class Trajnimi
    {
        public static Punetori punetori = new Punetori();
        public string EmriPlote { get; set; }
        private Departamenti _Departamenti = new Departamenti();
        public string DataFillimit { get; set; }
        public string DataPerfundimit { get; set; }
        public double Pagesa { get; set;}
        public string Departamenti { get; set; }
        public string Kompania { get; set; }

        public string Emriplote()
        {
            EmriPlote = punetori.Emri + " " + punetori.Mbiemri;
            return EmriPlote;
        }
        

        public Trajnimi(string emriplote, string departamenti, DateTime dataFillimit, DateTime dataPerfundimit, double pagesa, string kompania)
        {
            EmriPlote = emriplote;
            _Departamenti.EmriDepartamentit = departamenti;
            Departamenti = _Departamenti.EmriDepartamentit;
            DataFillimit = dataFillimit.Date.ToString("dd/MM/yyyy");
            DataPerfundimit = dataPerfundimit.Date.ToString("dd/MM/yyyy");
            Pagesa = pagesa;
            Kompania = kompania;
        }

        public Trajnimi()
        {
            //Default
        }
    }
}
