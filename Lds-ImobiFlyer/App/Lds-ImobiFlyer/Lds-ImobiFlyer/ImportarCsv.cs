using System.Data;

namespace Lds_ImobiFlyer
{
    public class ImportarCsv
    {
        // Ler Ficheiro para Tabela em memória RAM
        public static void ObterImoveis(DataTable dt, string ficheiro, char cSplit)
        {
            try
            {
                using var sr = new StreamReader(ficheiro);
                // Lê a primeira linha do ficheiro - cabeçalho
                var linha = sr.ReadLine();

                // Ler as restantes linhas e adiciona-as à tabela
                while ((linha = sr.ReadLine()) != null)
                {
                    // colunas
                    var col = linha.Split(cSplit);
                    int id = Convert.ToInt32(col[0]);
                    var valor = Convert.ToDecimal(col[3]);

                    // Adicionar à tabela
                    //dt.Rows.Add(id, col[1], col[2], valor, col[4], col[5], col[6].Substring(0, 1));
                    dt.Rows.Add(null, col[1], col[2], valor, col[4], col[5], col[6].Substring(0, 1));
                }
                sr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
