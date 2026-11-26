namespace PrinterAdapter.Adaptee
{
    /// <summary>
    /// существующий класс с несовместимым интерфейсом, его менять нельзя
    /// </summary>
    internal class PdfPrinter
    {
        public void PrintPdf(byte[] pdf, int copies)
        {
            Console.WriteLine($"PDF принтер: документ {pdf.Length} байт, копий {copies}");
        }
    }
}
