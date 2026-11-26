using System.Text;
using PrinterAdapter.Adaptee;
using PrinterAdapter.Target;

namespace PrinterAdapter.Adapters
{
    /// <summary>
    /// адаптер: превращает IPrinter.Print(string) в PdfPrinter.PrintPdf(byte[], int)
    /// </summary>
    internal class PdfPrinterAdapter : IPrinter
    {
        private readonly PdfPrinter _printer;
        private readonly int _copies;

        public PdfPrinterAdapter(PdfPrinter printer, int copies)
        {
            _printer = printer;
            _copies = copies;
        }

        public void Print(string text)
        {
            Console.WriteLine("Адаптер: текст преобразован в PDF");
            byte[] pdf = Encoding.UTF8.GetBytes(text);

            // сама печать делегируется существующему классу
            _printer.PrintPdf(pdf, _copies);
        }
    }
}
