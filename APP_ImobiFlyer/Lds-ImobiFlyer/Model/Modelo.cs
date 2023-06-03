using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lds_ImobiFlyer.Controller;
using Lds_ImobiFlyer.View;
using static System.Windows.Forms.LinkLabel;
using static Lds_ImobiFlyer.View.Visao;

namespace Lds_ImobiFlyer.Model
{
    class Modelo
    {
        private Visao visao;
        List<Imovel> imoveis;
        DataTable dtImoveis = new DataTable();

        public delegate void NotificarListaDeImoveisAlteradas();
        public event NotificarListaDeImoveisAlteradas ListaDeImoveisAlterada;

        public Modelo(Visao v)
        {
            visao = v;
            imoveis = new List<Imovel>();
        }

        public void ImportarTabela()
        {
            // Importar Ficheiro - Alterar a lista de imoveis
            Imoveis.Colunas(ref dtImoveis);
            Imoveis.ObterImoveis(ref dtImoveis);

            imoveis.Clear();
            foreach (DataRow dr in dtImoveis.Rows)
            {
                Imovel imovelAux = new Imovel();

                imovelAux.Id = Convert.ToInt32(dr[0]);
                imovelAux.DataMov = Convert.ToString(dr[1]);
                imovelAux.Tipologia = Convert.ToString(dr[2]);
                imovelAux.Valor = Convert.ToDecimal(dr[3]);
                imovelAux.Localidade = Convert.ToString(dr[4]);
                imovelAux.Finalidade = Convert.ToString(dr[5]);
                imovelAux.Status = Convert.ToChar(dr[6]);

                imoveis.Add(imovelAux);
            }

            // Notifica a que as listas foram alteradas.
            ListaDeImoveisAlterada();
        }

        public void SolicitarListaImoveis(ref List<Imovel> listadeimoveis)
        {
            listadeimoveis = new List<Imovel>();
            foreach (Imovel imv in imoveis)
            {
                listadeimoveis.Add(imv.Clone());
            }
        }

    }
}
