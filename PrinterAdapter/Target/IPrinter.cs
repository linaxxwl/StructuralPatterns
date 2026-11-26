namespace PrinterAdapter.Target
{
    /// <summary>
    /// интерфейс, который нужен клиенту
    /// </summary>
    internal interface IPrinter
    {
        void Print(string text); //печать текста
    }
}
