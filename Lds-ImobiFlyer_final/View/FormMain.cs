using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lds_ImobiFlyer.Controller;
using Lds_ImobiFlyer.Model;
using PdfSharp.Charting;
using PdfSharp.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lds_ImobiFlyer.View
{
    public partial class FormMain : Form
    {
        Visao visao;
        public FormMain()
        {
            InitializeComponent();
        }
        public Visao Visao { get => visao; set => visao = value; }

        public void Encerrar()
        {
            Application.Exit();
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            visao.CliqueEmImportarTabela(sender, e);
            Visao.CarregarComboSeleciona(ref cboSeleciona);
            txtMensagens.Text = "\n\nFicheiro Importado!";
            txtMensagens.Focus();
            txtMensagens.AppendText("  ");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            visao.CliqueEmSair(e);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            return;
        }

        private void cboSeleciona_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idAux = Convert.ToInt32("0" + cboSeleciona.Text);
            bool flag = false;
            Imovel imovel = null;
            flag = Visao.Procurar(idAux, ref imovel);
            if (flag)
            {
                txtId.Text = Convert.ToString(imovel.Id);
                txtTipologia.Text = Convert.ToString(imovel.Tipologia);
                txtData.Text = Convert.ToString(imovel.DataMov);
                txtValor.Text = Convert.ToString(imovel.Valor);
                txtLocalidade.Text = Convert.ToString(imovel.Localidade);
                txtDescricao.Text = Convert.ToString(imovel.Finalidade);
                cboStatus.Text = Convert.ToString(imovel.Status);
                textoStatus(imovel.Status);
            }
        }

        private void textoStatus(char status)
        {
            txtStatus.Text = "Ativo";
            switch (status)
            {
                case 'D':
                    txtStatus.Text = "Desistiu";
                    break;
                case 'V':
                    txtStatus.Text = "Vendido";
                    break;
                case 'X':
                    txtStatus.Text = "Anulado";
                    break;

                default:
                    cboStatus.Text = "A";
                    txtStatus.Text = "Ativo";
                    break;
            }
        }


        private void cboSeleciona_Leave(object sender, EventArgs e)
        {
            cboSeleciona.Text = "Selecionar";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void txtMensagens_Leave(object sender, EventArgs e)
        {
            txtMensagens.Text = string.Empty;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            GerarPDF gerarPdf = new GerarPDF();
            gerarPdf.Name = "Equipa ImobiFlyer";
            gerarPdf.Exportar(txtId.Text, "Equipa ImobiFlyer - UC 21179 - Laboratório de Desenvolvimento de Software");
        }

        private void btnPDFSoImagem_Click(object sender, EventArgs e)
        {
            GerarPDF gerarPdf = new GerarPDF();
            gerarPdf.Exportar(txtId.Text);
        }
    }
}
