using System.Data;
using System.Windows.Forms;

namespace Lds_ImobiFlyer.Controller
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        // pasta utilizada para os ficheiros 
        public const string pasta = @"\Lds-ImobiFlyer\";
        public const string ficheiro = pasta + "fchImoveis.csv";
        public const string ficheiroOut = pasta + "fchImoveisOut.csv";

        // caractere utlizado para separação de colunos no ficheiro "csv"
        public const char cSplit = ';';


        public delegate void GerarPdf(string mensagem);

        public static void ChamarApiPdf(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        public static void ImportarFicheiro(DataTable dtImoveis, DataGridView dgv1)
        {
            Imoveis.Colunas(dtImoveis);
            ImportarCsv.ObterImoveis(dtImoveis, ficheiro, cSplit);

            dgv1.DataSource = dtImoveis;
        }
    }
}