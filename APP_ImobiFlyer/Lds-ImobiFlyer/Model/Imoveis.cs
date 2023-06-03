using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lds_ImobiFlyer.Model
{
    internal class Imoveis
    {

        // pasta utilizada para os ficheiros 
        private const string pasta = @"\Lds-ImobiFlyer\";
        private const string ficheiro = pasta + "fchImoveis.csv";
        private const string ficheiroOut = pasta + "fchImoveisOut.csv";

        // Separador das colunas no ficheiro "csv"
        private const char cSplit = ';';


        //public static DataTable Colunas(DataTable dtImoveis) - utilizar passagem por referência
        public static void Colunas(ref DataTable dt)
        {
            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("ImoveisId", typeof(int));
            dt.Columns[0].AutoIncrement = true;
            dt.Columns[0].AutoIncrementSeed = 1;

            dt.Columns.Add("dataMov", typeof(string));
            dt.Columns.Add("tipologia", typeof(string));
            dt.Columns.Add("valor", typeof(decimal));
            dt.Columns.Add("localidade", typeof(string));
            dt.Columns.Add("finalidade", typeof(string));
            dt.Columns.Add("status", typeof(char));

            // return dtImoveis;
            // Form1.dataGridView1.DataSource = dtImoveis;   

        }

        // Ler Ficheiro para Tabela em memória RAM
        public static void ObterImoveis(ref DataTable dt)
        {
            try
            {
                using var sr = new StreamReader(ficheiro);
                // Lê a primeira linha do ficheiro - cabeçalho
                var linha = sr.ReadLine();

                dt.Rows.Clear();
                // Ler as restantes linhas e adiciona-as à tabela
                while ((linha = sr.ReadLine()) != null)
                {
                    // colunas
                    var col = linha.Split(cSplit);
                    int id = Convert.ToInt32(col[0]);
                    var valor = Convert.ToDecimal(col[3]);

                    // Adicionar à tabela
                    // ...Add(null, ...) em vez de ...Add(id, ...) para utilizar o incremento automático 
                    dt.Rows.Add(null, col[1], col[2], valor, col[4], col[5], col[6].Substring(0, 1));
                }
                sr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Gravar em Ficheiro os dados da Tabela
        public static bool Gravar(ref DataTable dt)
        {
            DialogResult resposta = MessageBox.Show("Vai Gravar Tabela em disco! \n\n Confirma?", "Gravar em Ficheiro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta != DialogResult.Yes)
            {
                return false;
            }
            try
            {
                using (var sw = new StreamWriter(ficheiroOut, false))
                {
                    string? linha = "";
                    // Grava a primeira linha - cabeçalho
                    sw.Write("id");
                    sw.Write(cSplit);
                    sw.Write("data");
                    sw.Write(cSplit);
                    sw.Write("tipologia");
                    sw.Write(cSplit);
                    sw.Write("localidade");
                    sw.Write(cSplit);
                    sw.Write("finalidade");
                    sw.Write(cSplit);
                    sw.Write("status");
                    sw.WriteLine();

                    // Gravar as restantes linhas
                    foreach (DataRow row in dt.Rows)
                    {
                        linha = Convert.ToString(row[0]);
                        for (int i = 1; i < dt.Columns.Count; i++)
                        {
                            linha += cSplit + Convert.ToString(row[i]);
                        }
                        sw.WriteLine(linha);
                    }
                    sw.Close();
                }
                MessageBox.Show("\nFicheiro: " + ficheiroOut + "\n\n\t gravado! \n\n", "Gravação do Fciheiro \"csv\"");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("\nError a gravar ficheiro: " + ficheiroOut + "\n", "Gravação do Fciheiro \"csv\"", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

    }
}
