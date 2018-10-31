using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiIBurimeveNjerezore
{
    public class Lista
    {

        public static List<Punetori> ListaPunetoreve = new List<Punetori>();
        public static List<Punedhenesi> ListaPunedhenesve = new List<Punedhenesi>();
        public static List<Departamenti> ListaDepartamenteve = new List<Departamenti>();
        public static List<Kontrata> ListaKontratave = new List<Kontrata>();
        public static List<Trajnimi> ListaTrajnimeve = new List<Trajnimi>();
        public static List<Pushimi> ListaPushimeve = new List<Pushimi>();

        public static void ShtoPunetorin(Punetori punetori)
        {
            array += 12;
            ListaPunetoreve.Add(punetori);
            Punetori.Id++;
        }

        public static void ShtoPunedhenesin(Punedhenesi punedhenesi)
        {
            ListaPunedhenesve.Add(punedhenesi);
            Punedhenesi.Id++;
        }

        public static void ShtoKontraten(Kontrata kontrata)
        {
            ListaKontratave.Add(kontrata);
        }

        public static void ShtoDepartamentin(Departamenti departamenti)
        {
            ListaDepartamenteve.Add(departamenti);
        }

        public static void FshijDepartament(Departamenti departament)
        {
            ListaDepartamenteve.Remove(departament);
        }

        public static void ShtoTrajnimin(Trajnimi trajnim)
        {
            ListaTrajnimeve.Add(trajnim);
        }

        public static void FshijTrajnimin(Trajnimi trajnim)
        {
            ListaTrajnimeve.Remove(trajnim);
        }

        public static void ShtoPushimet(Pushimi pushimi)
        {
            ListaPushimeve.Add(pushimi);
        }
    }
}
