using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MenaxhimiIBurimeveNjerezore
{
    public class Kontrata
    {
        public static string PunetoriKontrate;
        public static string PunedhenesiKontrate;
        private Departamenti _Departamenti = new Departamenti();
        public static string KualifikimiKontrate;
        public static string DepartamentiKontrate;
        public static string RrogaKontrate;
        public static string DataNenshkrimit;
        private static string DataNisjes;
        private static string DataPerfundimit;
        public static WebBrowser Webbrowser = new WebBrowser();

        public Kontrata(string punetori, string punedhenesi, string departamenti, string dataNenshkrimit, DateTime dataNisjes, DateTime dataPerfundimit, string kualifikimi, string RrogaBruto)
        {
            PunetoriKontrate = punetori;
            _Departamenti.EmriDepartamentit = departamenti;
            DepartamentiKontrate = _Departamenti.EmriDepartamentit;
            PunedhenesiKontrate = punedhenesi;
            DataNenshkrimit = dataNenshkrimit;
            DataNisjes = dataNisjes.ToString("dd/MM/yyyy");
            DataPerfundimit = dataPerfundimit.ToString("dd/MM/yyyy");
            KualifikimiKontrate = kualifikimi;
            RrogaKontrate = RrogaBruto;
        }

        internal static void GjeneroKontrate(Kontrata punetori)
        {
            Webbrowser.DocumentCompleted += Webbrowser_DocumentCompleted;
       
            string path = @"C:\Users\dreni\Desktop\Kontrata.html";
            using (StreamReader _file = new StreamReader(path))
            {
                //StreamReader _file = new StreamReader(File.Open(file, FileMode.Open));
                string Text = _file.ReadToEnd();

              
                Text = Text.Replace("#EmriMbiemri", PunetoriKontrate);
                Text = Text.Replace("#Kualifikimi", KualifikimiKontrate);
                Text = Text.Replace("#Departamenti", DepartamentiKontrate);
                Text = Text.Replace("#DataNisjes", DataNisjes);
                Text = Text.Replace("#DataPerfundimit", DataPerfundimit);
                Text = Text.Replace("#RrogaBruto", RrogaKontrate);
                Text = Text.Replace("#PunedhenesiEmri", PunedhenesiKontrate);
                Text = Text.Replace("#DataNenshkrimit", DataNenshkrimit);

                Webbrowser.DocumentText = Text;
            }
        }

        private static void Webbrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Webbrowser.ShowPrintPreviewDialog();
        }
    }
}

