using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lds_ImobiFlyer
{
    internal interface IPdf
    {
        public void Exportar(string x);
        public void Exportar(string x, string auxStr);
    }
}
