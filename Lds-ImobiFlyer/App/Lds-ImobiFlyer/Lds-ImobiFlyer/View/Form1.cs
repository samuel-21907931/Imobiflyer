using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Lds_ImobiFlyer.Controller;
using static Lds_ImobiFlyer.Controller.Program;

namespace Lds_ImobiFlyer
{
    public partial class Form1 : Form
    {
        //DataTable dtImoveis = new DataTable();
        DataTable dtImoveis = new();

        public bool flagAtualiza { get; private set; }
        public bool flagNovo { get; private set; }

        public Form1()
        {
            InitializeComponent();
            this.Text = "ImobiFlyer";
            flagAtualiza = false;
            flagNovo = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BotoesEnableInicial();
            Program.ImportarFicheiro(dtImoveis, dataGridView1);
            PosicionaUltimo();
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            Program.ImportarFicheiro(dtImoveis, dataGridView1);
        }

        private void AtualizarLinhaTabela(int id, DataTable dt)
        {
            MessageBox.Show("Falta implementar Atualizar Linha na Tabela", "Atualizar Linha na Tabela");

        }
        private void btnDataGridView_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                this.Width = 825;
                this.Height = 480;
                dataGridView1.Visible = false;
            }
            else
            {
                this.Width = 825;
                this.Height = 685;
                dataGridView1.Visible = true;
            }

        }


        private bool ValidarForm()
        {
            txtTipologia.Text = txtTipologia.Text.Trim();
            txtLocalidade.Text = txtLocalidade.Text.Trim();
            txtValor.Text = txtValor.Text.Trim();

            bool validar = true;
            if (txtTipologia.TextLength == 0)
            {
                MessageBox.Show("Campo \"Tipologia\" não poder ser vazio", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTipologia.Focus();
                validar = false;
            }
            if (txtLocalidade.TextLength == 0 && validar)
            {
                MessageBox.Show("Campo \"Localidade\" não poder ser vazio", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocalidade.Focus();
                validar = false;
            }

            // O campo Valor deve ter também validação se valor = 0
            if (txtValor.TextLength == 0 && validar)
            {
                MessageBox.Show("Campo \"Valor\" não poder ser vazio", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Focus();
                validar = false;
            }
            return validar;
        }

        private bool Procurar(int idAux, DataTable dt)
        {
            int valor = 0;
            btnSeleciona.Enabled = false;
            LimparForm1();
            bool encontrou = false;
            foreach (DataRow row in dt.Rows)
            {
                valor = (int)row["ImoveisId"];
                if (valor == idAux)
                {
                    txtId.Text = Convert.ToString(row["ImoveisId"]);
                    txtTipologia.Text = Convert.ToString(row["tipologia"]);
                    txtData.Text = Convert.ToString(row["dataMov"]);
                    txtValor.Text = Convert.ToString(row["valor"]);
                    txtLocalidade.Text = Convert.ToString(row["localidade"]);
                    txtDescricao.Text = Convert.ToString(row["finalidade"]);
                    //txtStatus.Text = row["status"].ToString;

                    encontrou = true;
                    break;
                }
            }
            flagAtualiza = false;
            return encontrou;
        }

        private void ProcuraAnterior(int idAux, DataTable dt)
        {
            idAux--;
            if (idAux <= 0)
                idAux = 1;

            Procurar(idAux, dt);
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ProcuraAnterior(Convert.ToInt32("0" + txtId.Text), dtImoveis);
        }

        private void ProcuraProximo(int idAux, DataTable dt)
        {
            idAux++;
            if (idAux >= dt.Rows.Count)
                idAux = dt.Rows.Count;

            Procurar(idAux, dt);
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            ProcuraProximo(Convert.ToInt32("0" + txtId.Text), dtImoveis);
        }

        private void btnSeleciona_Click(object sender, EventArgs e)
        {
            int idAux = 0;
            try
            {
                idAux = Convert.ToInt32("0" + txtIdAux.Text);
            }
            catch
            {
                idAux = dtImoveis.Rows.Count;
            }
            bool flag = false;
            flag = Procurar(idAux, dtImoveis);

            // Se não encontrou posiciona-se no último registo.
            if (!flag)
            {
                PosicionaUltimo();
            }
            txtIdAux.Text = string.Empty;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
        }


        private void txtIdAux_TextChanged(object sender, EventArgs e)
        {
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            int idAux = 0;
            try
            {
                idAux = Convert.ToInt32("0" + txtIdAux.Text);
            }
            catch
            {
                txtIdAux.Text = "0";
            }
            txtIdAux.Text = idAux.ToString();

            if (idAux > 0)
            {
                btnSeleciona.Enabled = true;
            }
            else
            {
                txtIdAux.SelectAll();
                txtIdAux.Focus();
            }
            return;

        }

        /*
         * ==================================================================================
         */
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("txtDescricao_TextChanged");
        }
        /*
         * ==================================================================================
         */

        private void LimparForm1()
        {
            txtId.Text = string.Empty;
            txtTipologia.Text = string.Empty;
            txtData.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtLocalidade.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GravarCsv.Gravar(dtImoveis, Program.ficheiroOut, Program.cSplit);
        }

        private void btnGrava_Click(object sender, EventArgs e)
        {
            GravarCsv.Gravar(dtImoveis, Program.ficheiroOut, Program.cSplit);
        }

        private void BotoesEnableInicial()
        {
            BotoesEnable(true);
            txtIdAux.Enabled = true;
            btnSeleciona.Enabled = false;
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = false;
            //btnAdicionar.Visible = true;
            //btnGravar.Visible = false;
        }
        private void BotoesEnable(Boolean flag)
        {
            btnDataGridView.Enabled = flag;
            btnGravar.Enabled = flag;
            btnAdicionar.Enabled = flag;
            btnTabela.Enabled = flag;
            btnSair.Enabled = flag;
            btnListaPDF.Enabled = flag;
            btnPDF.Enabled = flag;
            btnProximo.Enabled = flag;
            btnSeleciona.Enabled = flag;
            btnAnterior.Enabled = flag;
            btnNovo.Enabled = flag;
            btnCancelar.Enabled = flag;
        }



        private void PosicionaUltimo()
        {
            int idAux = 0;
            foreach (DataRow row in dtImoveis.Rows)
                idAux = (int)row["ImoveisId"];
            Procurar(idAux, dtImoveis);
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            flagNovo = true;
            BotoesEnable(false);
            txtIdAux.Enabled = false;
            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = true;
            LimparForm1();
            txtData.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (!ValidarForm())
            {
                return;
            }

            // Adicionar à tabela
            try
            {
                var valor = Convert.ToDecimal(txtValor.Text);

                dtImoveis.Rows.Add(null, txtData.Text, txtTipologia.Text, valor, txtLocalidade.Text, txtDescricao.Text, 'A');

                PosicionaUltimo();
                BotoesEnableInicial();
                flagNovo = false;
                return;
            }
            catch
            {
                MessageBox.Show("Erro ao adicionar à tabela");
                return;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            flagAtualiza = false;
            LimparForm1();
            PosicionaUltimo();
            BotoesEnableInicial();
            flagAtualiza = false;
            flagNovo = false;
            return;
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            flagAtualiza = true;
        }

        private void txtTipologia_TextChanged(object sender, EventArgs e)
        {
            flagAtualiza = true;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            flagAtualiza = true;
        }

        private void txtLocalidade_TextChanged(object sender, EventArgs e)
        {
            flagAtualiza = true;
        }

        private void txtDescricao_TextChanged_1(object sender, EventArgs e)
        {
            flagAtualiza = true;
        }

        private void panel1_Leave(object sender, EventArgs e)
        {

            if (flagAtualiza && !flagNovo)
            {
                int idAux = 0;
                int idAuxRow = 0;
                idAux = Convert.ToInt32(txtId.Text);
                foreach (DataRow row in dtImoveis.Rows)
                {
                    idAuxRow = (int)row["ImoveisId"];
                    if (idAuxRow == idAux)
                    {
                        var valor = Convert.ToDecimal(txtValor.Text);
                        row[0] = idAux;
                        row[1] = txtData.Text;
                        row[2] = txtTipologia.Text;
                        row[3] = valor;
                        row[4] = txtLocalidade.Text;
                        row[5] = txtDescricao.Text;
                        //row[6]= txtStatus.Text[0];

                        MessageBox.Show("Ola - panel1_Leave: " + flagAtualiza);
                        break;
                    }
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            //GerarPdf gerarPdf = new("Teste de  btnPDF_Click");
            GerarPdf gerarPdf = new(ChamarApiPdf);
            gerarPdf.Invoke("Teste de Evento: btnPDF_Click (na Forms1 em: Lds_ImobiFlyer)"
                + "\n\n" + "Utiliza Delegado: GerarPdf"
                + "\n" + "que está em: Lds_ImobiFlyer.Controller.Program "
                + "\n\n" + "que chama método: ChamarApiPdf"
                + "\n" + "também em: Lds_ImobiFlyer.Controller.Program");

        }
    }
}

