namespace Lds_ImobiFlyer.View
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel3 = new Panel();
            txtMensagens = new TextBox();
            btnTabela = new Button();
            panel2 = new Panel();
            cboSeleciona = new ComboBox();
            btnSair = new Button();
            btnPDF = new Button();
            panel1 = new Panel();
            txtStatus = new TextBox();
            label10 = new Label();
            cboStatus = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            txtDescricao = new TextBox();
            txtLocalidade = new TextBox();
            txtValor = new TextBox();
            txtTipologia = new TextBox();
            txtData = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtId = new TextBox();
            pictureBox2 = new PictureBox();
            btnPDFSoImagem = new Button();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtMensagens);
            panel3.Location = new Point(16, 461);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(892, 117);
            panel3.TabIndex = 55;
            // 
            // txtMensagens
            // 
            txtMensagens.BorderStyle = BorderStyle.None;
            txtMensagens.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMensagens.Location = new Point(9, 13);
            txtMensagens.Multiline = true;
            txtMensagens.Name = "txtMensagens";
            txtMensagens.ReadOnly = true;
            txtMensagens.ScrollBars = ScrollBars.Both;
            txtMensagens.Size = new Size(868, 88);
            txtMensagens.TabIndex = 0;
            txtMensagens.TextAlign = HorizontalAlignment.Center;
            txtMensagens.Leave += txtMensagens_Leave;
            // 
            // btnTabela
            // 
            btnTabela.Location = new Point(28, 17);
            btnTabela.Margin = new Padding(3, 4, 3, 4);
            btnTabela.Name = "btnTabela";
            btnTabela.Size = new Size(160, 31);
            btnTabela.TabIndex = 57;
            btnTabela.Text = "Importar Tabela";
            btnTabela.UseVisualStyleBackColor = true;
            btnTabela.Click += btnTabela_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnPDFSoImagem);
            panel2.Controls.Add(cboSeleciona);
            panel2.Controls.Add(btnTabela);
            panel2.Controls.Add(btnSair);
            panel2.Controls.Add(btnPDF);
            panel2.Location = new Point(16, 386);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 67);
            panel2.TabIndex = 54;
            // 
            // cboSeleciona
            // 
            cboSeleciona.FormatString = "N0";
            cboSeleciona.FormattingEnabled = true;
            cboSeleciona.Location = new Point(244, 20);
            cboSeleciona.Margin = new Padding(3, 4, 3, 4);
            cboSeleciona.Name = "cboSeleciona";
            cboSeleciona.Size = new Size(110, 28);
            cboSeleciona.TabIndex = 62;
            cboSeleciona.Text = "Selecionar";
            cboSeleciona.SelectedIndexChanged += cboSeleciona_SelectedIndexChanged;
            cboSeleciona.Leave += cboSeleciona_Leave;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(772, 20);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 31);
            btnSair.TabIndex = 56;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(445, 16);
            btnPDF.Margin = new Padding(3, 4, 3, 4);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(82, 32);
            btnPDF.TabIndex = 53;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtStatus);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cboStatus);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtDescricao);
            panel1.Controls.Add(txtLocalidade);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(txtTipologia);
            panel1.Controls.Add(txtData);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(16, 10);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 371);
            panel1.TabIndex = 53;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(559, 9);
            txtStatus.Margin = new Padding(3, 4, 3, 4);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(114, 27);
            txtStatus.TabIndex = 47;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(445, 11);
            label10.Name = "label10";
            label10.Size = new Size(68, 25);
            label10.TabIndex = 46;
            label10.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.Enabled = false;
            cboStatus.FlatStyle = FlatStyle.Popup;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(510, 9);
            cboStatus.Margin = new Padding(3, 4, 3, 4);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(42, 28);
            cboStatus.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(201, 331);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 44;
            label7.Text = "Contactar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(314, 331);
            label8.Name = "label8";
            label8.Size = new Size(248, 23);
            label8.TabIndex = 43;
            label8.Text = "comercial@ImobiFlyer.com";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(680, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 151);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(130, 209);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ReadOnly = true;
            txtDescricao.Size = new Size(746, 112);
            txtDescricao.TabIndex = 40;
            // 
            // txtLocalidade
            // 
            txtLocalidade.Location = new Point(130, 171);
            txtLocalidade.Margin = new Padding(3, 4, 3, 4);
            txtLocalidade.Name = "txtLocalidade";
            txtLocalidade.ReadOnly = true;
            txtLocalidade.Size = new Size(746, 27);
            txtLocalidade.TabIndex = 39;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(130, 132);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.ReadOnly = true;
            txtValor.Size = new Size(186, 27);
            txtValor.TabIndex = 38;
            // 
            // txtTipologia
            // 
            txtTipologia.Location = new Point(130, 89);
            txtTipologia.Margin = new Padding(3, 4, 3, 4);
            txtTipologia.Name = "txtTipologia";
            txtTipologia.ReadOnly = true;
            txtTipologia.Size = new Size(542, 27);
            txtTipologia.TabIndex = 37;
            // 
            // txtData
            // 
            txtData.Location = new Point(130, 51);
            txtData.Margin = new Padding(3, 4, 3, 4);
            txtData.Name = "txtData";
            txtData.ReadOnly = true;
            txtData.Size = new Size(114, 27);
            txtData.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 213);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 35;
            label4.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 172);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 34;
            label5.Text = "Localidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 133);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 33;
            label6.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 91);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 32;
            label3.Text = "Tipologia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 52);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 31;
            label2.Text = "Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 13);
            label1.Name = "label1";
            label1.Size = new Size(31, 25);
            label1.TabIndex = 30;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(130, 12);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 29;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 275);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 88);
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // btnPDFSoImagem
            // 
            btnPDFSoImagem.Location = new Point(553, 16);
            btnPDFSoImagem.Margin = new Padding(3, 4, 3, 4);
            btnPDFSoImagem.Name = "btnPDFSoImagem";
            btnPDFSoImagem.Size = new Size(119, 32);
            btnPDFSoImagem.TabIndex = 63;
            btnPDFSoImagem.Text = "PDF Imagem";
            btnPDFSoImagem.UseVisualStyleBackColor = true;
            btnPDFSoImagem.Click += btnPDFSoImagem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 588);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Button btnTabela;
        private Panel panel2;
        private ComboBox cboSeleciona;
        private Button btnSair;
        private Button btnPDF;
        private Panel panel1;
        private TextBox txtStatus;
        private Label label10;
        private ComboBox cboStatus;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private TextBox txtDescricao;
        private TextBox txtLocalidade;
        private TextBox txtValor;
        private TextBox txtTipologia;
        private TextBox txtData;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtId;
        private PictureBox pictureBox2;
        private TextBox txtMensagens;
        private Button btnPDFSoImagem;
    }
}