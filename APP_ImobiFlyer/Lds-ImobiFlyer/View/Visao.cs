using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lds_ImobiFlyer.Controller;
using Lds_ImobiFlyer.Model;

namespace Lds_ImobiFlyer.View
{
    public partial class Visao
    {
        private Modelo modelo;
        private FormMain janela;

        private List<Imovel> listaImoveis;

        public event EventHandler UtilizadorClicouEmImportarTabela;

        public event System.EventHandler UtilizadorClicouEmSair;

        public delegate void SolicitacaoListaImoveis(ref List<Imovel> listadeimoveis);
        public event SolicitacaoListaImoveis PrecisoDeImoveis;

        internal Visao(Modelo m)
        {
            modelo = m;
        }

        public void AtivarInterface()
        {
            janela = new FormMain();
            janela.Visao = this;
            janela.ShowDialog();
        }

        public void CliqueEmSair(EventArgs e)
        {
            UtilizadorClicouEmSair(this, e);
        }

        public void Encerrar()
        {
            janela.Encerrar();
        }

        public void CliqueEmImportarTabela(object origem, EventArgs e)
        {
            UtilizadorClicouEmImportarTabela(this, e);
        }

        public void AtualizarListaDeImoveis()
        {
            // Atualizar a lista de imoveis recebidas do Model
            PrecisoDeImoveis(ref listaImoveis);
            MostrarImovel();
        }

        public void CarregarComboSeleciona(ref ComboBox comboBox)
        {
            int idAux = 0;
            comboBox.Items.Clear();
            foreach (Imovel imv in listaImoveis)
            {
                //listadeimoveis.Add(imv.Clone());
                idAux = imv.Id;
                comboBox.Items.Add(idAux);
            }
        }

        //void MostrarImovel(ref List<Imovel> lista)
        public void MostrarImovel()
        {

        }

        public bool Procurar(int idAux, ref Imovel imovel)
        {
            int valor = 0;
            bool encontrou = false;
            foreach (Imovel imv in listaImoveis)
            {
                valor = (int)imv.Id;
                if (valor == idAux)
                {
                    imovel = imv;
                    encontrou = true;
                    break;
                }
            }
            return encontrou;
        }
    }
}
