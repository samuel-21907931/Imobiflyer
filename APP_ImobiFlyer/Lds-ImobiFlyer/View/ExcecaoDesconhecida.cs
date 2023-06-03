using Lds_ImobiFlyer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lds_ImobiFlyer.View
{
    internal class AppExcecaoDesconhecida : Exception
    {
        public StatusPossiveis tipoImovelDesconhecido;

        public AppExcecaoDesconhecida()
        {
        }

        public AppExcecaoDesconhecida(StatusPossiveis tipoStatus)
        {
            this.tipoImovelDesconhecido = tipoStatus;
        }

        public AppExcecaoDesconhecida(string message) : base(message)
        {
        }

        public AppExcecaoDesconhecida(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AppExcecaoDesconhecida(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
