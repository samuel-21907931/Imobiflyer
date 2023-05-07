using System.Data;

namespace Lds_ImobiFlyer
{
    public class Imoveis
    {
        public static DataTable Colunas(DataTable dtImoveis)
        {
            dtImoveis.Clear();
            dtImoveis.Columns.Clear();

            dtImoveis.Columns.Add("ImoveisId", typeof(Int32));
            dtImoveis.Columns[0].AutoIncrement = true;
            dtImoveis.Columns[0].AutoIncrementSeed = 1;

            dtImoveis.Columns.Add("dataMov", typeof(string));
            dtImoveis.Columns.Add("tipologia", typeof(string));
            dtImoveis.Columns.Add("valor", typeof(decimal));
            dtImoveis.Columns.Add("localidade", typeof(string));
            dtImoveis.Columns.Add("finalidade", typeof(string));
            dtImoveis.Columns.Add("status", typeof(char));

            return dtImoveis;
        }
    }
}
