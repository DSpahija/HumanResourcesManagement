using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiIBurimeveNjerezore
{
    public class Pushimi
    {
        //Pushim vjetor = 20
        //Pushim mjeksor = 20
        //Pushim martesor = 7 
        //Rast vdekje = 3
        //Udhtim zyrtar = ditet caktuar nga kompania
        //Punetori punetoriID = new Punetori(); ne baze te ID me gjet punetori = pushimet qe i ka
        public string _PunetoriEmri;
        public string _PunetoriID;
        private int _PushimiVjetor;
        private int _PushimiMjekesor=20;
        private int _PushimiMartesor=7;
        private int _RastVdekje=3;
        public int UdhetimZyrtar;
        
        public int PushimiVjetorDitet
        {
            get { return _PushimiVjetor; }
            set
            {
                _PushimiVjetor = value;
            }
        }

        public int PushimiMjekesorDitet
        {
            get { return _PushimiMjekesor; }
            set
            { 
                _PushimiMjekesor = value;
                if(_PushimiMjekesor > 20)
                {
                    MessageBox.Show("Pushimi mjekesor ka vetem 20 dite!");
                }
            }
        }

        public int PushimiMartesorDitet
        {
            get { return _PushimiMartesor; }
            set
            {

                _PushimiMartesor = value;
                if (_PushimiMartesor > 7)
                {
                    MessageBox.Show("Pushimi martesor ka vetem 7 dite!");
                }
            }
        }

        public int RastVdekjeDitet
        {
            get { return _RastVdekje; }
            set
            {

                _RastVdekje = value;
                if (_RastVdekje > 3)
                {
                    MessageBox.Show("Ne rast vdekje, punetori ka te drejte te marr pushim vetem 3 dite!");
                }
            }
        }

        public Pushimi()
        {
            //Default
        }

        public string tostring()
        {
            return _PunetoriEmri;
        }

        public Pushimi(string idPunetori, string Emri, int pushimiVjetor, int pushimiMjekesor, int pushimiMartesor, int rastVdekje, int udhetimZyrtar)
        {
            _PunetoriEmri = Emri;
            _PunetoriID = idPunetori;
            PushimiVjetorDitet = pushimiVjetor;
            PushimiMjekesorDitet = pushimiMjekesor;
            PushimiMartesorDitet = pushimiMartesor;
            RastVdekjeDitet = rastVdekje;
            UdhetimZyrtar = udhetimZyrtar;
        }

    }
}
