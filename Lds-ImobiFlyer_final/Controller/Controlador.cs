using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Lds_ImobiFlyer.View;
using Lds_ImobiFlyer.Model;
using System.Windows.Forms;

namespace Lds_ImobiFlyer.Controller
{
    class Controlador
    {
        Modelo modelo;
        Visao visao;
        bool sair;

        public delegate void AtivacaoInterface(object origem);
        public event AtivacaoInterface AtivarInterface;

        public Controlador()
        {
            sair = false;
            visao = new Visao(modelo);
            modelo = new Modelo(visao);

            visao.UtilizadorClicouEmSair += UtilizadorClicouEmSair;

            modelo.ListaDeImoveisAlterada += visao.AtualizarListaDeImoveis;

            visao.UtilizadorClicouEmImportarTabela += UtilizadorClicouEmImportarTabela;
            visao.PrecisoDeImoveis += modelo.SolicitarListaImoveis;
        }

        private void ErroExcecaoDesconhecido(string v)
        {
            throw new NotImplementedException();
        }

        public void IniciarPrograma()
        {
            do
            {
                try
                {
                    visao.AtivarInterface();
                }
                catch (AppExcecaoDesconhecida ex)
                {
                    ErroExcecaoDesconhecido(ex.ToString());
                }
            } while (!sair);
        }

         public void UtilizadorClicouEmImportarTabela(object fonte, System.EventArgs args)
        {
            modelo.ImportarTabela();
        }

        private void UtilizadorClicouEmSair(object sender, EventArgs e)
        {
            sair = true;
            visao.Encerrar();
        }
    }
}
