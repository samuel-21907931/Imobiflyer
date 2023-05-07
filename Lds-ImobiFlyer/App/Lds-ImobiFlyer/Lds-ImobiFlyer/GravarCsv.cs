using System.ComponentModel;
using System.Data;
using Lds_ImobiFlyer.Controller;

namespace Lds_ImobiFlyer
{
    internal class GravarCsv
    {
        // Gravar em Ficheiro os dados da Tabela
        public static bool Gravar(DataTable dt, string ficheiroOutCsv, char cSplit)
        {
            DialogResult resposta = MessageBox.Show("Vai Gravar Tabela em disco! \n\n Confirma?", "Gravar em Ficheiro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta != DialogResult.Yes)
            {
                return false;
            }
            try
            {
                using (var sw = new StreamWriter(ficheiroOutCsv, false))
                {
                    String linha = "";
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
                        /*
                        linha += cSplit + Convert.ToString(row["tipologia"]);
                        linha += cSplit + Convert.ToString(row["valor"]);
                        linha += cSplit + Convert.ToString(row["localidade"]);
                        linha += cSplit + Convert.ToString(row["finalidade"]);
                        linha += cSplit + Convert.ToString(row["status"]);
                        */
                        sw.WriteLine(linha);
                    }
                    sw.Close();
                }
                MessageBox.Show("\nFicheiro: " + Program.ficheiroOut + "\n\n\t gravado! \n\n", "Gravação do Fciheiro \"csv\"");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("\nError a gravar ficheiro: " + Program.ficheiroOut + "\n", "Gravação do Fciheiro \"csv\"", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }
    }
}
