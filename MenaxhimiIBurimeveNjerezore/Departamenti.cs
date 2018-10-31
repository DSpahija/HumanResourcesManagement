using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiIBurimeveNjerezore
{
    public class Departamenti
    {
        public protected string EmriDepartamentit { get; set; }
        public Departamenti(string emridepartamentit)
        {
            EmriDepartamentit = emridepartamentit;
        }

        public override string ToString()
        {
            return EmriDepartamentit;
        }

        public Departamenti()
        {
            //Default
        }
    }
}
