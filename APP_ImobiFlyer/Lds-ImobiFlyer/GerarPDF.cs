using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lds_ImobiFlyer
{
    internal class GerarPDF : IPdf
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Exportar(string idFlyer, string auxStr)
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                var page = doc.AddPage();
                page.Size = PdfSharp.PageSize.A5;
                page.Orientation = PdfSharp.PageOrientation.Landscape;

                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var corFont = PdfSharp.Drawing.XBrushes.Black;
                var tipoFont = new PdfSharp.Drawing.XFont("Arial", 14);
                var tipoFont1 = new PdfSharp.Drawing.XFont("Arial", 10);
                var tipoFont2 = new PdfSharp.Drawing.XFont("Arial", 18);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);

                var flyer = @"Flyer nº " + idFlyer.Trim();
                var ficheiro = @"C:\Lds-ImobiFlyer\" + idFlyer.Trim() + ".png";
                var arquivo = @"C:\Lds-ImobiFlyer\" + idFlyer.Trim() + "A5.pdf";
                try
                {
                    textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                    textFormatter.DrawString(this.name, tipoFont2, PdfSharp.Drawing.XBrushes.Blue, new PdfSharp.Drawing.XRect(0, 25, page.Width, page.Height));
                    textFormatter.DrawString(flyer, tipoFont, PdfSharp.Drawing.XBrushes.Red, new PdfSharp.Drawing.XRect(0, 50, page.Width, page.Height));
                    XImage imagem = XImage.FromFile(ficheiro);
                    graphics.DrawImage(imagem, 60, 90, 490, 180);
                    textFormatter.DrawString(auxStr, tipoFont1, PdfSharp.Drawing.XBrushes.DarkOrange, new PdfSharp.Drawing.XRect(10, 300, page.Width, page.Height));
                    doc.Save(arquivo);
                }
                catch
                {
                    MessageBox.Show("Erro no ficheiro de escrita " + ficheiro + "\n\n\t Não foi gerado ficheiro 'pdf'");
                }
                try
                {
                    string appName = "C:\\Program Files\\Adobe\\Acrobat DC\\Acrobat\\Acrobat.exe";
                    Process.Start(appName, arquivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no ficheiro de leitura " + arquivo + "\n\n" + ex.ToString());
                }
            }
        }

        public void Exportar(string idFlyer)
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                var page = doc.AddPage();
                page.Size = PdfSharp.PageSize.B5;
                page.Orientation = PdfSharp.PageOrientation.Portrait;

                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var ficheiro = @"C:\Lds-ImobiFlyer\" + idFlyer.Trim() + ".png";
                var arquivo = @"C:\Lds-ImobiFlyer\" + idFlyer.Trim() + "B5.pdf";
                try
                {
                    XImage imagem = XImage.FromFile(ficheiro);
                    graphics.DrawImage(imagem, 5, 200, 490, 180);
                    doc.Save(arquivo);
                }
                catch
                {
                    MessageBox.Show("Erro no ficheiro de escrita " + ficheiro + "\n\n\t Não foi gerado ficheiro 'pdf'");
                }
                try
                {
                    string appName = "C:\\Program Files\\Adobe\\Acrobat DC\\Acrobat\\Acrobat.exe";
                    Process.Start(appName, arquivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no ficheiro de leitura " + arquivo + "\n\n" + ex.ToString());
                }
            }
        }

    }
}
