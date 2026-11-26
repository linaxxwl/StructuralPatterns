using PrinterAdapter;
using PrinterAdapter.Adaptee;
using PrinterAdapter.Adapters;
using PrinterAdapter.Target;

internal class Program
{
    static void Main(string[] args)
    {
        // один и тот же клиентский код OfficeClient.PrintReport() работает с двумя разными адаптерами

        Console.WriteLine("[Печать одной копии]");
        IPrinter singleCopyPrinter = new PdfPrinterAdapter(new PdfPrinter(), 1);
        var firstClient = new OfficeClient(singleCopyPrinter);
        firstClient.PrintReport();

        Console.WriteLine("[Печать трех копий]");
        IPrinter threeCopiesPrinter = new PdfPrinterAdapter(new PdfPrinter(), 3);
        var secondClient = new OfficeClient(threeCopiesPrinter);
        secondClient.PrintReport();
    }
}
