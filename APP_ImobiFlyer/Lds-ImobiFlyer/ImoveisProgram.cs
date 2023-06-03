using Lds_ImobiFlyer.Controller;
using Lds_ImobiFlyer.View;
using System.Data;

namespace Lds_ImobiFlyer
{
    internal static class ImoveisProgram
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
           
            Controlador controlador = new Controlador();
            controlador.IniciarPrograma();

        }
    }
}