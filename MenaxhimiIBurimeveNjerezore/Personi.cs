using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiIBurimeveNjerezore
{
    public class Personi
    {
        public static int Id=1;
        public string FullID;
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

        public Personi()
        {
            //Default
        }

        public virtual string IDMetode()
        {
            return FullID = Id + "";
        }
    }
}
