using PrinterAdapter.Target;

namespace PrinterAdapter
{
    /// <summary>
    /// клиентский код, знает только про IPrinter
    /// </summary>
    internal class OfficeClient
    {
        private readonly IPrinter _printer;

        public OfficeClient(IPrinter printer)
        {
            _printer = printer;
        }

        // одинаковый сценарий для любого принтера
        public void PrintReport()
        {
            Console.WriteLine("Отправляем отчет на печать");
            _printer.Print("Отчет за месяц");
            Console.WriteLine("Печать завершена\n");
        }
    }
}
