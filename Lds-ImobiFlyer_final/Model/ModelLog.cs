using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lds_ImobiFlyer.Model
{
    internal class ModelLog
    {
        public delegate void NotificacaoLogAlterado();
        public event NotificacaoLogAlterado NotificarLogAlterado;

        private string log;

        public ModelLog()
        {
            log = "";
        }

        public void LogErro(StatusPossiveis tipoStatus)
        {
            log += "Tipo de Status desconhecido: " + tipoStatus.ToString() + System.Environment.NewLine;
            NotificarLogAlterado();
        }

        public string SolicitarLog()
        {
            return log;
        }
    }
}
